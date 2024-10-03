namespace IMSWGU
{
    partial class MainForm
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
            label3 = new Label();
            deletePartButton = new Button();
            partGridView = new DataGridView();
            modifyPartButton = new Button();
            addPartButton = new Button();
            searchPartButton = new Button();
            partSearchTextBox = new TextBox();
            exitAppButton = new Button();
            productSearchTextBox = new TextBox();
            searchProductButton = new Button();
            addProductButton = new Button();
            modifyProductButton = new Button();
            productGridView = new DataGridView();
            deleteProductButton = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)partGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 148);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 20;
            label3.Text = "Parts";
            // 
            // deletePartButton
            // 
            deletePartButton.Location = new Point(291, 129);
            deletePartButton.Name = "deletePartButton";
            deletePartButton.Size = new Size(75, 28);
            deletePartButton.TabIndex = 19;
            deletePartButton.Text = "Delete";
            deletePartButton.UseVisualStyleBackColor = true;
            deletePartButton.Click += DeletePartButton_Click;
            // 
            // partGridView
            // 
            partGridView.AllowUserToAddRows = false;
            partGridView.AllowUserToDeleteRows = false;
            partGridView.AllowUserToResizeColumns = false;
            partGridView.AllowUserToResizeRows = false;
            partGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            partGridView.Location = new Point(2, 176);
            partGridView.MultiSelect = false;
            partGridView.Name = "partGridView";
            partGridView.ReadOnly = true;
            partGridView.RowHeadersVisible = false;
            partGridView.RowHeadersWidth = 51;
            partGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partGridView.Size = new Size(484, 259);
            partGridView.TabIndex = 13;
            // 
            // modifyPartButton
            // 
            modifyPartButton.Location = new Point(176, 129);
            modifyPartButton.Name = "modifyPartButton";
            modifyPartButton.Size = new Size(75, 28);
            modifyPartButton.TabIndex = 18;
            modifyPartButton.Text = "Modify";
            modifyPartButton.UseVisualStyleBackColor = true;
            modifyPartButton.Click += ModifyPartButton_Click;
            // 
            // addPartButton
            // 
            addPartButton.Location = new Point(70, 130);
            addPartButton.Name = "addPartButton";
            addPartButton.Size = new Size(75, 28);
            addPartButton.TabIndex = 17;
            addPartButton.Text = "Add";
            addPartButton.UseVisualStyleBackColor = true;
            addPartButton.Click += AddPartButton_Click;
            // 
            // searchPartButton
            // 
            searchPartButton.Location = new Point(59, 95);
            searchPartButton.Name = "searchPartButton";
            searchPartButton.Size = new Size(75, 28);
            searchPartButton.TabIndex = 15;
            searchPartButton.Text = "Search";
            searchPartButton.UseVisualStyleBackColor = true;
            searchPartButton.Click += SearchPartButton_Click;
            // 
            // partSearchTextBox
            // 
            partSearchTextBox.Location = new Point(140, 96);
            partSearchTextBox.Name = "partSearchTextBox";
            partSearchTextBox.Size = new Size(156, 27);
            partSearchTextBox.TabIndex = 16;
            // 
            // exitAppButton
            // 
            exitAppButton.Location = new Point(907, 441);
            exitAppButton.Name = "exitAppButton";
            exitAppButton.Size = new Size(75, 28);
            exitAppButton.TabIndex = 21;
            exitAppButton.Text = "Exit";
            exitAppButton.UseVisualStyleBackColor = true;
            exitAppButton.Click += ExitAppButton_Click;
            // 
            // productSearchTextBox
            // 
            productSearchTextBox.Location = new Point(687, 95);
            productSearchTextBox.Name = "productSearchTextBox";
            productSearchTextBox.Size = new Size(156, 27);
            productSearchTextBox.TabIndex = 16;
            // 
            // searchProductButton
            // 
            searchProductButton.Location = new Point(606, 95);
            searchProductButton.Name = "searchProductButton";
            searchProductButton.Size = new Size(75, 28);
            searchProductButton.TabIndex = 15;
            searchProductButton.Text = "Search";
            searchProductButton.UseVisualStyleBackColor = true;
            searchProductButton.Click += SearchProductButton_Click;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(606, 129);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(75, 28);
            addProductButton.TabIndex = 17;
            addProductButton.Text = "Add";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += AddProductButton_Click;
            // 
            // modifyProductButton
            // 
            modifyProductButton.Location = new Point(729, 129);
            modifyProductButton.Name = "modifyProductButton";
            modifyProductButton.Size = new Size(75, 28);
            modifyProductButton.TabIndex = 18;
            modifyProductButton.Text = "Modify";
            modifyProductButton.UseVisualStyleBackColor = true;
            modifyProductButton.Click += ModifyProductButton_Click;
            // 
            // productGridView
            // 
            productGridView.AllowUserToAddRows = false;
            productGridView.AllowUserToDeleteRows = false;
            productGridView.AllowUserToResizeColumns = false;
            productGridView.AllowUserToResizeRows = false;
            productGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            productGridView.Location = new Point(520, 176);
            productGridView.MultiSelect = false;
            productGridView.Name = "productGridView";
            productGridView.ReadOnly = true;
            productGridView.RowHeadersVisible = false;
            productGridView.RowHeadersWidth = 51;
            productGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productGridView.Size = new Size(484, 259);
            productGridView.TabIndex = 13;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(852, 129);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(75, 28);
            deleteProductButton.TabIndex = 19;
            deleteProductButton.Text = "Delete";
            deleteProductButton.UseVisualStyleBackColor = true;
            deleteProductButton.Click += DeleteProductButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(520, 148);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 20;
            label2.Text = "Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(686, 67);
            label1.TabIndex = 22;
            label1.Text = "Inventory Management System";
            // 
            // MainForm
            // 
            ClientSize = new Size(1016, 470);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(deleteProductButton);
            Controls.Add(partSearchTextBox);
            Controls.Add(searchPartButton);
            Controls.Add(addPartButton);
            Controls.Add(modifyPartButton);
            Controls.Add(deletePartButton);
            Controls.Add(label2);
            Controls.Add(partGridView);
            Controls.Add(productGridView);
            Controls.Add(modifyProductButton);
            Controls.Add(exitAppButton);
            Controls.Add(addProductButton);
            Controls.Add(productSearchTextBox);
            Controls.Add(searchProductButton);
            Name = "MainForm";
            Text = "IMS";
            ((System.ComponentModel.ISupportInitialize)partGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button searchPartButton;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitAppButton;
        public System.Windows.Forms.DataGridView partGridView;
        public DataGridView productGridView;
        private TextBox productSearchTextBox;
        private Button searchProductButton;
        private Button addProductButton;
        private Button modifyProductButton;
        private Button deleteProductButton;
        private Label label2;
        private Label label1;
    }
}

