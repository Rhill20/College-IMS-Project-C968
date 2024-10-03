using System;
using System.Collections;
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
    public partial class Add_Product : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        public Add_Product()
        {
            InitializeComponent();

            var topTable = new BindingSource();
            topTable.DataSource = new BindingList<Part>(Inventory.Parts.Except(addedParts).ToList());
            candidatePartsGrid.DataSource = topTable;

            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            associatedPartsGrid.DataSource = botTable;
        }


        private void CancelAddProductbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (associatedPartsGrid.CurrentRow == null) return;
                Part partToRemove = (Part)associatedPartsGrid.CurrentRow.DataBoundItem;
                addedParts.Remove(partToRemove);

                // Add back to candidate list
                var candidateParts = (BindingList<Part>)((BindingSource)candidatePartsGrid.DataSource).DataSource;
                candidateParts.Add(partToRemove);

            
            }
        }

        private void SearchPartListButton_Click(object sender, EventArgs e)
        {
            string searchText = searchPartTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a valid search term.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in candidatePartsGrid.Rows)
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

        private void AddPartToItemButton_Click(object sender, EventArgs e)
        {
            if (candidatePartsGrid.CurrentRow == null) return;
            Part partToAdd = (Part)candidatePartsGrid.CurrentRow.DataBoundItem;
            addedParts.Add(partToAdd);

            // Remove from candidate list 
            var candidateParts = (BindingList<Part>)((BindingSource)candidatePartsGrid.DataSource).DataSource;
            candidateParts.Remove(partToAdd);
        }

        private void SaveNewProductButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(addProductMinTextBox.Text, out int min) ||
                !int.TryParse(addProductMaxTextBox.Text, out int max) ||
                !int.TryParse(addProductInventoryTextBox.Text, out int inventory) ||
                !decimal.TryParse(addProductPriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Error: Inventory, Price, Max, and Min must be numeric values.");
                return;
            }

            string name = addProductNameTextBox.Text;

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

            Product product = new Product(Inventory.Products.Count + 1, name, inventory, price, max, min);
            Inventory.AddProduct(product);

            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }

            Close();
        }

       
    }
}
