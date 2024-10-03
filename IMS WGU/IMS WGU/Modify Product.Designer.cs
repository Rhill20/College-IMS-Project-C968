namespace IMSWGU
{
    partial class Modify_Product
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
            saveNewProductButton = new Button();
            cancelAddProductbutton = new Button();
            label9 = new Label();
            deleteAssociatedPartButton = new Button();
            modAssociatedPartsGrid = new DataGridView();
            addPartToItemButton = new Button();
            searchPartListButton = new Button();
            modPartSearchTextBox = new TextBox();
            modProductMinTextBox = new TextBox();
            modProductMaxTextBox = new TextBox();
            modProductPriceTextBox = new TextBox();
            modProductInventoryTextBox = new TextBox();
            modProductNameTextBox = new TextBox();
            modProductIDTextBox = new TextBox();
            label8 = new Label();
            modCandidatePartsGrid = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)modAssociatedPartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modCandidatePartsGrid).BeginInit();
            SuspendLayout();
            // 
            // saveNewProductButton
            // 
            saveNewProductButton.Location = new Point(93, 388);
            saveNewProductButton.Margin = new Padding(4, 3, 4, 3);
            saveNewProductButton.Name = "saveNewProductButton";
            saveNewProductButton.Size = new Size(88, 27);
            saveNewProductButton.TabIndex = 45;
            saveNewProductButton.Text = "Save";
            saveNewProductButton.UseVisualStyleBackColor = true;
            saveNewProductButton.Click += SaveNewProductButton_Click;
            // 
            // cancelAddProductbutton
            // 
            cancelAddProductbutton.Location = new Point(223, 388);
            cancelAddProductbutton.Margin = new Padding(4, 3, 4, 3);
            cancelAddProductbutton.Name = "cancelAddProductbutton";
            cancelAddProductbutton.Size = new Size(88, 27);
            cancelAddProductbutton.TabIndex = 44;
            cancelAddProductbutton.Text = "Cancel";
            cancelAddProductbutton.UseVisualStyleBackColor = true;
            cancelAddProductbutton.Click += CancelAddProductbutton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(387, 308);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 43;
            label9.Text = "Parts Associated with this Product";
            // 
            // deleteAssociatedPartButton
            // 
            deleteAssociatedPartButton.Location = new Point(851, 518);
            deleteAssociatedPartButton.Margin = new Padding(4, 3, 4, 3);
            deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            deleteAssociatedPartButton.Size = new Size(69, 31);
            deleteAssociatedPartButton.TabIndex = 42;
            deleteAssociatedPartButton.Text = "Delete";
            deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            deleteAssociatedPartButton.Click += DeleteAssociatedPartButton_Click;
            // 
            // modAssociatedPartsGrid
            // 
            modAssociatedPartsGrid.AllowUserToAddRows = false;
            modAssociatedPartsGrid.AllowUserToDeleteRows = false;
            modAssociatedPartsGrid.AllowUserToResizeColumns = false;
            modAssociatedPartsGrid.AllowUserToResizeRows = false;
            modAssociatedPartsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            modAssociatedPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            modAssociatedPartsGrid.Location = new Point(391, 326);
            modAssociatedPartsGrid.Margin = new Padding(4, 3, 4, 3);
            modAssociatedPartsGrid.Name = "modAssociatedPartsGrid";
            modAssociatedPartsGrid.ReadOnly = true;
            modAssociatedPartsGrid.RowHeadersVisible = false;
            modAssociatedPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modAssociatedPartsGrid.Size = new Size(529, 186);
            modAssociatedPartsGrid.TabIndex = 41;
            // 
            // addPartToItemButton
            // 
            addPartToItemButton.Location = new Point(852, 262);
            addPartToItemButton.Margin = new Padding(4, 3, 4, 3);
            addPartToItemButton.Name = "addPartToItemButton";
            addPartToItemButton.Size = new Size(68, 32);
            addPartToItemButton.TabIndex = 40;
            addPartToItemButton.Text = "Add";
            addPartToItemButton.UseVisualStyleBackColor = true;
            addPartToItemButton.Click += AddPartToItemButton_Click;
            // 
            // searchPartListButton
            // 
            searchPartListButton.Location = new Point(609, 25);
            searchPartListButton.Margin = new Padding(4, 3, 4, 3);
            searchPartListButton.Name = "searchPartListButton";
            searchPartListButton.Size = new Size(64, 23);
            searchPartListButton.TabIndex = 39;
            searchPartListButton.Text = "Search";
            searchPartListButton.UseVisualStyleBackColor = true;
            searchPartListButton.Click += SearchPartListButton_Click;
            // 
            // modPartSearchTextBox
            // 
            modPartSearchTextBox.Location = new Point(691, 25);
            modPartSearchTextBox.Margin = new Padding(4, 3, 4, 3);
            modPartSearchTextBox.Name = "modPartSearchTextBox";
            modPartSearchTextBox.Size = new Size(195, 23);
            modPartSearchTextBox.TabIndex = 38;
            // 
            // modProductMinTextBox
            // 
            modProductMinTextBox.Location = new Point(116, 344);
            modProductMinTextBox.Margin = new Padding(4, 3, 4, 3);
            modProductMinTextBox.Name = "modProductMinTextBox";
            modProductMinTextBox.Size = new Size(65, 23);
            modProductMinTextBox.TabIndex = 37;
            // 
            // modProductMaxTextBox
            // 
            modProductMaxTextBox.Location = new Point(223, 344);
            modProductMaxTextBox.Margin = new Padding(4, 3, 4, 3);
            modProductMaxTextBox.Name = "modProductMaxTextBox";
            modProductMaxTextBox.Size = new Size(59, 23);
            modProductMaxTextBox.TabIndex = 36;
            // 
            // modProductPriceTextBox
            // 
            modProductPriceTextBox.Location = new Point(141, 285);
            modProductPriceTextBox.Margin = new Padding(4, 3, 4, 3);
            modProductPriceTextBox.Name = "modProductPriceTextBox";
            modProductPriceTextBox.Size = new Size(116, 23);
            modProductPriceTextBox.TabIndex = 35;
            // 
            // modProductInventoryTextBox
            // 
            modProductInventoryTextBox.Location = new Point(141, 237);
            modProductInventoryTextBox.Margin = new Padding(4, 3, 4, 3);
            modProductInventoryTextBox.Name = "modProductInventoryTextBox";
            modProductInventoryTextBox.Size = new Size(116, 23);
            modProductInventoryTextBox.TabIndex = 34;
            // 
            // modProductNameTextBox
            // 
            modProductNameTextBox.Location = new Point(141, 190);
            modProductNameTextBox.Margin = new Padding(4, 3, 4, 3);
            modProductNameTextBox.Name = "modProductNameTextBox";
            modProductNameTextBox.Size = new Size(116, 23);
            modProductNameTextBox.TabIndex = 33;
            // 
            // modProductIDTextBox
            // 
            modProductIDTextBox.Location = new Point(141, 145);
            modProductIDTextBox.Margin = new Padding(4, 3, 4, 3);
            modProductIDTextBox.Name = "modProductIDTextBox";
            modProductIDTextBox.ReadOnly = true;
            modProductIDTextBox.Size = new Size(116, 23);
            modProductIDTextBox.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(387, 52);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 31;
            label8.Text = "All Candidate Parts";
            // 
            // modCandidatePartsGrid
            // 
            modCandidatePartsGrid.AllowUserToAddRows = false;
            modCandidatePartsGrid.AllowUserToDeleteRows = false;
            modCandidatePartsGrid.AllowUserToResizeColumns = false;
            modCandidatePartsGrid.AllowUserToResizeRows = false;
            modCandidatePartsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            modCandidatePartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            modCandidatePartsGrid.Location = new Point(391, 70);
            modCandidatePartsGrid.Margin = new Padding(4, 3, 4, 3);
            modCandidatePartsGrid.Name = "modCandidatePartsGrid";
            modCandidatePartsGrid.ReadOnly = true;
            modCandidatePartsGrid.RowHeadersVisible = false;
            modCandidatePartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modCandidatePartsGrid.Size = new Size(529, 186);
            modCandidatePartsGrid.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(137, 326);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 29;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 326);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 28;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 285);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 27;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 246);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 26;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 25;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 24;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 33);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 46;
            label1.Text = "Modify Product";
            // 
            // Modify_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 584);
            Controls.Add(label1);
            Controls.Add(saveNewProductButton);
            Controls.Add(cancelAddProductbutton);
            Controls.Add(label9);
            Controls.Add(deleteAssociatedPartButton);
            Controls.Add(modAssociatedPartsGrid);
            Controls.Add(addPartToItemButton);
            Controls.Add(searchPartListButton);
            Controls.Add(modPartSearchTextBox);
            Controls.Add(modProductMinTextBox);
            Controls.Add(modProductMaxTextBox);
            Controls.Add(modProductPriceTextBox);
            Controls.Add(modProductInventoryTextBox);
            Controls.Add(modProductNameTextBox);
            Controls.Add(modProductIDTextBox);
            Controls.Add(label8);
            Controls.Add(modCandidatePartsGrid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Modify_Product";
            Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)modAssociatedPartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)modCandidatePartsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button saveNewProductButton;
        private System.Windows.Forms.Button cancelAddProductbutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteAssociatedPartButton;
        private System.Windows.Forms.DataGridView modAssociatedPartsGrid;
        private System.Windows.Forms.Button addPartToItemButton;
        private System.Windows.Forms.Button searchPartListButton;
        private System.Windows.Forms.TextBox modPartSearchTextBox;
        private System.Windows.Forms.TextBox modProductMinTextBox;
        private System.Windows.Forms.TextBox modProductMaxTextBox;
        private System.Windows.Forms.TextBox modProductPriceTextBox;
        private System.Windows.Forms.TextBox modProductInventoryTextBox;
        private System.Windows.Forms.TextBox modProductNameTextBox;
        private System.Windows.Forms.TextBox modProductIDTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView modCandidatePartsGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Label label1;
    }
}