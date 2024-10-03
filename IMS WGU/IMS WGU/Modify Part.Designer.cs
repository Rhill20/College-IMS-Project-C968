namespace IMSWGU
{
    partial class Modify_Part
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancelPartCreationButton = new Button();
            savePartButton = new Button();
            modPartMacComTextBox = new TextBox();
            modPartMinTextBox = new TextBox();
            modPartMaxTextBox = new TextBox();
            modPartCostTextBox = new TextBox();
            modPartInventoryTextBox = new TextBox();
            modPartNameTextBox = new TextBox();
            modPartIDTextBox = new TextBox();
            MacComLbl = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            outsourcedRadioButton = new RadioButton();
            inhouseRadioButton = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // cancelPartCreationButton
            // 
            cancelPartCreationButton.Location = new Point(400, 334);
            cancelPartCreationButton.Margin = new Padding(4, 3, 4, 3);
            cancelPartCreationButton.Name = "cancelPartCreationButton";
            cancelPartCreationButton.Size = new Size(88, 27);
            cancelPartCreationButton.TabIndex = 38;
            cancelPartCreationButton.Text = "Cancel";
            cancelPartCreationButton.UseVisualStyleBackColor = true;
            cancelPartCreationButton.Click += CancelPartCreationButton_Click;
            // 
            // savePartButton
            // 
            savePartButton.Location = new Point(293, 334);
            savePartButton.Margin = new Padding(4, 3, 4, 3);
            savePartButton.Name = "savePartButton";
            savePartButton.Size = new Size(88, 27);
            savePartButton.TabIndex = 37;
            savePartButton.Text = "Save";
            savePartButton.UseVisualStyleBackColor = true;
            savePartButton.Click += SavePartButton_Click;
            // 
            // modPartMacComTextBox
            // 
            modPartMacComTextBox.Location = new Point(159, 256);
            modPartMacComTextBox.Margin = new Padding(4, 3, 4, 3);
            modPartMacComTextBox.Name = "modPartMacComTextBox";
            modPartMacComTextBox.Size = new Size(116, 23);
            modPartMacComTextBox.TabIndex = 36;
            // 
            // modPartMinTextBox
            // 
            modPartMinTextBox.Location = new Point(331, 216);
            modPartMinTextBox.Margin = new Padding(4, 3, 4, 3);
            modPartMinTextBox.Name = "modPartMinTextBox";
            modPartMinTextBox.Size = new Size(86, 23);
            modPartMinTextBox.TabIndex = 35;
            // 
            // modPartMaxTextBox
            // 
            modPartMaxTextBox.Location = new Point(159, 217);
            modPartMaxTextBox.Margin = new Padding(4, 3, 4, 3);
            modPartMaxTextBox.Name = "modPartMaxTextBox";
            modPartMaxTextBox.Size = new Size(79, 23);
            modPartMaxTextBox.TabIndex = 34;
            // 
            // modPartCostTextBox
            // 
            modPartCostTextBox.Location = new Point(159, 178);
            modPartCostTextBox.Margin = new Padding(4, 3, 4, 3);
            modPartCostTextBox.Name = "modPartCostTextBox";
            modPartCostTextBox.Size = new Size(116, 23);
            modPartCostTextBox.TabIndex = 33;
            // 
            // modPartInventoryTextBox
            // 
            modPartInventoryTextBox.Location = new Point(159, 143);
            modPartInventoryTextBox.Margin = new Padding(4, 3, 4, 3);
            modPartInventoryTextBox.Name = "modPartInventoryTextBox";
            modPartInventoryTextBox.Size = new Size(116, 23);
            modPartInventoryTextBox.TabIndex = 32;
            // 
            // modPartNameTextBox
            // 
            modPartNameTextBox.Location = new Point(159, 107);
            modPartNameTextBox.Margin = new Padding(4, 3, 4, 3);
            modPartNameTextBox.Name = "modPartNameTextBox";
            modPartNameTextBox.Size = new Size(116, 23);
            modPartNameTextBox.TabIndex = 31;
            // 
            // modPartIDTextBox
            // 
            modPartIDTextBox.Location = new Point(159, 69);
            modPartIDTextBox.Margin = new Padding(4, 3, 4, 3);
            modPartIDTextBox.Name = "modPartIDTextBox";
            modPartIDTextBox.ReadOnly = true;
            modPartIDTextBox.Size = new Size(116, 23);
            modPartIDTextBox.TabIndex = 30;
            // 
            // MacComLbl
            // 
            MacComLbl.AutoSize = true;
            MacComLbl.Location = new Point(63, 264);
            MacComLbl.Margin = new Padding(4, 0, 4, 0);
            MacComLbl.Name = "MacComLbl";
            MacComLbl.Size = new Size(67, 15);
            MacComLbl.TabIndex = 29;
            MacComLbl.Text = "Machine ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(273, 226);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 28;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 226);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 27;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 186);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 26;
            label5.Text = "Price / Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 151);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 25;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 24;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 23;
            label2.Text = "ID";
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Location = new Point(329, 14);
            outsourcedRadioButton.Margin = new Padding(4, 3, 4, 3);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(87, 19);
            outsourcedRadioButton.TabIndex = 22;
            outsourcedRadioButton.TabStop = true;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            outsourcedRadioButton.CheckedChanged += OutsourcedRadioButton_CheckedChanged;
            // 
            // inhouseRadioButton
            // 
            inhouseRadioButton.AutoSize = true;
            inhouseRadioButton.Location = new Point(201, 13);
            inhouseRadioButton.Margin = new Padding(4, 3, 4, 3);
            inhouseRadioButton.Name = "inhouseRadioButton";
            inhouseRadioButton.Size = new Size(74, 19);
            inhouseRadioButton.TabIndex = 21;
            inhouseRadioButton.TabStop = true;
            inhouseRadioButton.Text = "In-House";
            inhouseRadioButton.UseVisualStyleBackColor = true;
            inhouseRadioButton.CheckedChanged += InhouseRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 18);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 39;
            label1.Text = "Modify Part";
            // 
            // Modify_Part
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 397);
            Controls.Add(label1);
            Controls.Add(cancelPartCreationButton);
            Controls.Add(savePartButton);
            Controls.Add(modPartMacComTextBox);
            Controls.Add(modPartMinTextBox);
            Controls.Add(modPartMaxTextBox);
            Controls.Add(modPartCostTextBox);
            Controls.Add(modPartInventoryTextBox);
            Controls.Add(modPartNameTextBox);
            Controls.Add(modPartIDTextBox);
            Controls.Add(MacComLbl);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(outsourcedRadioButton);
            Controls.Add(inhouseRadioButton);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Modify_Part";
            Text = "Modify Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cancelPartCreationButton;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.TextBox modPartMacComTextBox;
        private System.Windows.Forms.TextBox modPartMinTextBox;
        private System.Windows.Forms.TextBox modPartMaxTextBox;
        private System.Windows.Forms.TextBox modPartCostTextBox;
        private System.Windows.Forms.TextBox modPartInventoryTextBox;
        private System.Windows.Forms.TextBox modPartNameTextBox;
        private System.Windows.Forms.TextBox modPartIDTextBox;
        private System.Windows.Forms.Label MacComLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.RadioButton inhouseRadioButton;
        private Label label1;
    }
}