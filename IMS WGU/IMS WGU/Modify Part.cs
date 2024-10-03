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
    public partial class Modify_Part : Form
    {
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];

       
        public Modify_Part(InHousePart inPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = inPart.PartID.ToString();
            modPartNameTextBox.Text = inPart.Name;
            modPartInventoryTextBox.Text = inPart.Inventory.ToString();
            modPartCostTextBox.Text = inPart.Price.Substring(1).ToString();
            modPartMaxTextBox.Text = inPart.Max.ToString();
            modPartMinTextBox.Text = inPart.Min.ToString();
            modPartMacComTextBox.Text = inPart.MachineID.ToString();
        }

        public Modify_Part(OutsourcedPart outPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = outPart.PartID.ToString();
            modPartNameTextBox.Text = outPart.Name;
            modPartInventoryTextBox.Text = outPart.Inventory.ToString();
            modPartCostTextBox.Text = outPart.Price.Substring(1).ToString();
            modPartMaxTextBox.Text = outPart.Max.ToString();
            modPartMinTextBox.Text = outPart.Min.ToString();
            modPartMacComTextBox.Text = outPart.CompName;

            outsourcedRadioButton.Checked = true;
        }
        
        private void SavePartButton_Click(object sender, EventArgs e)
        {
            int minStock, maxStock, invInStock;
            decimal price;

            if (!int.TryParse(modPartMinTextBox.Text, out minStock) ||
                !int.TryParse(modPartMaxTextBox.Text, out maxStock) ||
                !int.TryParse(modPartInventoryTextBox.Text, out invInStock) ||
                !decimal.TryParse(modPartCostTextBox.Text, out price))
            {
                MessageBox.Show("Error: Inventory, Price, Max, and Min must be numeric values.");
                return;
            }

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

            int id = int.Parse(modPartIDTextBox.Text);
            string name = modPartNameTextBox.Text;

            if (inhouseRadioButton.Checked)
            {
                if (!int.TryParse(modPartMacComTextBox.Text, out int machineId))
                {
                    MessageBox.Show("Error: Machine ID must be a numeric value for In-House parts.");
                    return;
                }

                InHousePart inPart = new InHousePart(id, name, invInStock, price, maxStock, minStock, machineId);
                Inventory.UpdatePart(id, inPart);
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart(id, name, invInStock, price, maxStock, minStock, modPartMacComTextBox.Text);
                Inventory.UpdatePart(id, outPart);
            }

            Close();
            MainWindow.partGridView.Update();
            MainWindow.partGridView.Refresh();
        }
        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MacComLbl.Text = "Company Name";
        }
        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MacComLbl.Text = "Machine ID";
        }
        private void CancelPartCreationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
