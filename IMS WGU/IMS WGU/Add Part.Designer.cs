namespace IMSWGU
{
    partial class Add_Part
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
            inhouseRadioButton = new RadioButton();
            outsourcedRadioButton = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comMacLabel = new Label();
            partIDTextBox = new TextBox();
            partNameTextBox = new TextBox();
            partInventoryTextBox = new TextBox();
            partCostTextBox = new TextBox();
            partMaxTextBox = new TextBox();
            partMinTextBox = new TextBox();
            partMacComTextBox = new TextBox();
            savePartButton = new Button();
            cancelPartCreationButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // inhouseRadioButton
            // 
            inhouseRadioButton.AutoSize = true;
            inhouseRadioButton.Location = new Point(202, 17);
            inhouseRadioButton.Margin = new Padding(4, 3, 4, 3);
            inhouseRadioButton.Name = "inhouseRadioButton";
            inhouseRadioButton.Size = new Size(74, 19);
            inhouseRadioButton.TabIndex = 1;
            inhouseRadioButton.TabStop = true;
            inhouseRadioButton.Text = "In-House";
            inhouseRadioButton.UseVisualStyleBackColor = true;
            inhouseRadioButton.CheckedChanged += InhouseRadioButton_CheckedChanged;
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Location = new Point(330, 18);
            outsourcedRadioButton.Margin = new Padding(4, 3, 4, 3);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(87, 19);
            outsourcedRadioButton.TabIndex = 2;
            outsourcedRadioButton.TabStop = true;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            outsourcedRadioButton.CheckedChanged += OutsourcedRadioButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 164);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 198);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 6;
            label5.Text = "Price / Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 239);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 7;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 239);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 8;
            label7.Text = "Min";
            // 
            // comMacLabel
            // 
            comMacLabel.AutoSize = true;
            comMacLabel.Location = new Point(64, 277);
            comMacLabel.Margin = new Padding(4, 0, 4, 0);
            comMacLabel.Name = "comMacLabel";
            comMacLabel.Size = new Size(67, 15);
            comMacLabel.TabIndex = 9;
            comMacLabel.Text = "Machine ID";
            // 
            // partIDTextBox
            // 
            partIDTextBox.Location = new Point(160, 87);
            partIDTextBox.Margin = new Padding(4, 3, 4, 3);
            partIDTextBox.Name = "partIDTextBox";
            partIDTextBox.ReadOnly = true;
            partIDTextBox.Size = new Size(116, 23);
            partIDTextBox.TabIndex = 10;
            // 
            // partNameTextBox
            // 
            partNameTextBox.Location = new Point(160, 120);
            partNameTextBox.Margin = new Padding(4, 3, 4, 3);
            partNameTextBox.Name = "partNameTextBox";
            partNameTextBox.Size = new Size(116, 23);
            partNameTextBox.TabIndex = 11;
            // 
            // partInventoryTextBox
            // 
            partInventoryTextBox.Location = new Point(160, 156);
            partInventoryTextBox.Margin = new Padding(4, 3, 4, 3);
            partInventoryTextBox.Name = "partInventoryTextBox";
            partInventoryTextBox.Size = new Size(116, 23);
            partInventoryTextBox.TabIndex = 12;
            // 
            // partCostTextBox
            // 
            partCostTextBox.Location = new Point(160, 190);
            partCostTextBox.Margin = new Padding(4, 3, 4, 3);
            partCostTextBox.Name = "partCostTextBox";
            partCostTextBox.Size = new Size(116, 23);
            partCostTextBox.TabIndex = 13;
            // 
            // partMaxTextBox
            // 
            partMaxTextBox.Location = new Point(160, 230);
            partMaxTextBox.Margin = new Padding(4, 3, 4, 3);
            partMaxTextBox.Name = "partMaxTextBox";
            partMaxTextBox.Size = new Size(79, 23);
            partMaxTextBox.TabIndex = 14;
            // 
            // partMinTextBox
            // 
            partMinTextBox.Location = new Point(332, 228);
            partMinTextBox.Margin = new Padding(4, 3, 4, 3);
            partMinTextBox.Name = "partMinTextBox";
            partMinTextBox.Size = new Size(86, 23);
            partMinTextBox.TabIndex = 15;
            // 
            // partMacComTextBox
            // 
            partMacComTextBox.Location = new Point(160, 269);
            partMacComTextBox.Margin = new Padding(4, 3, 4, 3);
            partMacComTextBox.Name = "partMacComTextBox";
            partMacComTextBox.Size = new Size(116, 23);
            partMacComTextBox.TabIndex = 16;
            // 
            // savePartButton
            // 
            savePartButton.Location = new Point(294, 346);
            savePartButton.Margin = new Padding(4, 3, 4, 3);
            savePartButton.Name = "savePartButton";
            savePartButton.Size = new Size(88, 27);
            savePartButton.TabIndex = 18;
            savePartButton.Text = "Save";
            savePartButton.UseVisualStyleBackColor = true;
            savePartButton.Click += SavePartButton_Click;
            // 
            // cancelPartCreationButton
            // 
            cancelPartCreationButton.Location = new Point(401, 346);
            cancelPartCreationButton.Margin = new Padding(4, 3, 4, 3);
            cancelPartCreationButton.Name = "cancelPartCreationButton";
            cancelPartCreationButton.Size = new Size(88, 27);
            cancelPartCreationButton.TabIndex = 19;
            cancelPartCreationButton.Text = "Cancel";
            cancelPartCreationButton.UseVisualStyleBackColor = true;
            cancelPartCreationButton.Click += CancelPartCreationButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 20;
            label1.Text = "Add Part";
            // 
            // Add_Part
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 420);
            Controls.Add(label1);
            Controls.Add(cancelPartCreationButton);
            Controls.Add(savePartButton);
            Controls.Add(partMacComTextBox);
            Controls.Add(partMinTextBox);
            Controls.Add(partMaxTextBox);
            Controls.Add(partCostTextBox);
            Controls.Add(partInventoryTextBox);
            Controls.Add(partNameTextBox);
            Controls.Add(partIDTextBox);
            Controls.Add(comMacLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(outsourcedRadioButton);
            Controls.Add(inhouseRadioButton);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Add_Part";
            Text = "Add Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RadioButton inhouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label comMacLabel;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partInventoryTextBox;
        private System.Windows.Forms.TextBox partCostTextBox;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.TextBox partMacComTextBox;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Button cancelPartCreationButton;
        private Label label1;
    }
}