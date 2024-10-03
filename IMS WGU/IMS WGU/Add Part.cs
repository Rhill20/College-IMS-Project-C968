using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMSWGU
{
    public partial class Add_Part : Form
    {

        public Add_Part()
        {
            InitializeComponent();
        }
        private void SavePartButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(partMinTextBox.Text, out int minStock) ||
                !int.TryParse(partMaxTextBox.Text, out int maxStock) ||
                !int.TryParse(partInventoryTextBox.Text, out int invInStock) ||
                !decimal.TryParse(partCostTextBox.Text, out decimal price))
            {
                MessageBox.Show("Error: Inventory, Price, Max, and Min must be numeric values.");
                return;
            }

            string name = partNameTextBox.Text;

            if (minStock > maxStock)
            {
                MessageBox.Show("Error: Max must be greater than Min.");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Error: Inventory must be between Min and Max.");
                return;
            }

            if (inhouseRadioButton.Checked)
            {
                if (!int.TryParse(partMacComTextBox.Text, out int machineId))
                {
                    MessageBox.Show("Machine ID must be a numeric value for In-House parts.");
                    return;
                }
                InHousePart inPart = new InHousePart((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, machineId);
                Inventory.AddPart(inPart);
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, partMacComTextBox.Text);
                Inventory.AddPart(outPart);
            }

            Close();
        }
        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            comMacLabel.Text = "Machine ID";
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            comMacLabel.Text = "Company Name";
        }
        private void CancelPartCreationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
