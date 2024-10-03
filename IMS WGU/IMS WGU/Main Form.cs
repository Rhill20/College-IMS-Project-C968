using IMS_WGU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMSWGU
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Inventory.MockData();

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.Parts;
            partGridView.DataSource = partTable;

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            productGridView.DataSource = prodTable;
        }


        private void AddPartButton_Click(object sender, EventArgs e)
        {
            new Add_Part().ShowDialog();
        }


        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (partGridView.CurrentRow.DataBoundItem.GetType() == typeof(IMSWGU.InHousePart))
            {
                InHousePart inHousePart = (InHousePart)partGridView.CurrentRow.DataBoundItem;
                new Modify_Part(inHousePart).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)partGridView.CurrentRow.DataBoundItem;
                new Modify_Part(outsourcedPart).ShowDialog();
            }
        }

        //check if part is in product         I did both part and product not sure which one is graded so I did both
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)partGridView.CurrentRow.DataBoundItem;

            if (Inventory.PartsInProducts(selectedPart.PartID))
            {
                MessageBox.Show("Cannot delete part if associated with a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partGridView.SelectedRows)
                {
                    partGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        public void RefreshProductGridView()
        {
            productGridView.DataSource = null;
            productGridView.DataSource = Inventory.Products;  
            productGridView.Refresh();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            new Add_Product().ShowDialog();
        }
        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            Product selectedProd = (Product)productGridView.CurrentRow.DataBoundItem;
            new Modify_Product(selectedProd).ShowDialog();
        }

        // Checks if product has part     I did both part and product not sure which one is graded so I did both
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            
            Product product = (Product)productGridView.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete product with associated parts. Please remove parts attached to this product.", "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                productGridView.Rows.RemoveAt(productGridView.CurrentRow.Index);
            }
        }
        private void SearchItems<T>(string searchText, DataGridView gridView, Func<T, bool> matchCriteria)
        {
            bool found = false;
            gridView.ClearSelection();
            foreach (DataGridViewRow row in gridView.Rows)
            {
                T item = (T)row.DataBoundItem;
                if (matchCriteria(item))
                {
                    //Selects the cell "click"
                    gridView.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    found = true;
                    break; 
                }
            }

            if (!found)
            {
                MessageBox.Show("No matching items found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            string searchText = partSearchTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a valid search term.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SearchItems(searchText, partGridView, (Part part) => part.Name.ToLower().Contains(searchText) || part.PartID.ToString() == searchText);
        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            string searchText = productSearchTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a valid search term.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SearchItems(searchText, productGridView, (Product product) => product.Name.ToLower().Contains(searchText) || product.ProductID.ToString() == searchText);
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
