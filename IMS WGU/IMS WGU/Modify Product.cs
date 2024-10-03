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
    public partial class Modify_Product : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];
        public Modify_Product(Product prod)
        {
            InitializeComponent();

            //product populated with selected product
            modProductIDTextBox.Text = prod.ProductID.ToString();
            modProductNameTextBox.Text = prod.Name;
            modProductInventoryTextBox.Text = prod.Inventory.ToString();
            modProductPriceTextBox.Text = prod.Price.Substring(1).ToString();
            modProductMaxTextBox.Text = prod.Max.ToString();
            modProductMinTextBox.Text = prod.Min.ToString();

            foreach (Part part in prod.AssociatedParts)
            {
                addedParts.Add(part);
            }
            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            modAssociatedPartsGrid.DataSource = botTable;

            // Exclude already added parts from the candidate list
            var availableParts = new BindingList<Part>(Inventory.Parts.Where(p => !addedParts.Any(ap => ap.PartID == p.PartID)).ToList());
            var topTable = new BindingSource();
            topTable.DataSource = availableParts;
            modCandidatePartsGrid.DataSource = topTable;
        }
        private void CancelAddProductbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveNewProductButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(modProductMinTextBox.Text, out int min) ||
                !int.TryParse(modProductMaxTextBox.Text, out int max) ||
                !int.TryParse(modProductInventoryTextBox.Text, out int inventory) ||
                !decimal.TryParse(modProductPriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Error: Inventory, Price, Max, and Min must be numeric values.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Error: Min cannot be greater than Max.");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: Inventory must be between Min and Max.");
                return;
            }

            int id = int.Parse(modProductIDTextBox.Text);
            string name = modProductNameTextBox.Text;

            Product product = new Product(id, name, inventory, price, max, min);
            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Inventory.UpdateProduct(id, product);
            Close();
            MainWindow.RefreshProductGridView();
        }

        private void AddPartToItemButton_Click(object sender, EventArgs e)
        {
            if (modCandidatePartsGrid.CurrentRow == null) return;

            Part part = (Part)modCandidatePartsGrid.CurrentRow.DataBoundItem;
            addedParts.Add(part);

            // Remove the part from the candidate data grid
            ((BindingList<Part>)((BindingSource)modCandidatePartsGrid.DataSource).DataSource).Remove(part);
        }

        private void SearchPartListButton_Click(object sender, EventArgs e)
        {
            string searchText = modPartSearchTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a valid search term.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in modCandidatePartsGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.Name.ToLower().Contains(searchText) || part.PartID.ToString() == searchText)
                {
                    row.Selected = true;
                    found = true;
                }
                else
                {
                    row.Selected = false;
                }
            }

            if (!found)
            {
                MessageBox.Show("No matching parts found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (modAssociatedPartsGrid.CurrentRow == null) return;

                Part part = (Part)modAssociatedPartsGrid.CurrentRow.DataBoundItem;
                addedParts.Remove(part);

               
                var candidateParts = ((BindingList<Part>)((BindingSource)modCandidatePartsGrid.DataSource).DataSource);
                if (!candidateParts.Any(p => p.PartID == part.PartID))
                {
                    
                    candidateParts.Add(part);
                }

                modAssociatedPartsGrid.DataSource = null;
                modAssociatedPartsGrid.DataSource = new BindingSource { DataSource = addedParts };
                modCandidatePartsGrid.DataSource = null;
                modCandidatePartsGrid.DataSource = new BindingSource { DataSource = candidateParts };
            }
        }
    }
}
