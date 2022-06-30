namespace WindowsForms.UI.UserCTRL.Products
{
    partial class ProductsGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ModelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeoductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AllowUserToAddRows = false;
            this.ProductsGridView.AllowUserToDeleteRows = false;
            this.ProductsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))));
            this.ProductsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelId,
            this.PeoductName,
            this.Manufacturer,
            this.ManDate,
            this.Price,
            this.Availability});
            this.ProductsGridView.GridColor = System.Drawing.Color.Black;
            this.ProductsGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.ReadOnly = true;
            this.ProductsGridView.RowTemplate.Height = 27;
            this.ProductsGridView.Size = new System.Drawing.Size(914, 631);
            this.ProductsGridView.TabIndex = 1;
            // 
            // ModelId
            // 
            this.ModelId.DataPropertyName = "ModelId";
            this.ModelId.HeaderText = "Model ID";
            this.ModelId.Name = "ModelId";
            this.ModelId.ReadOnly = true;
            // 
            // PeoductName
            // 
            this.PeoductName.DataPropertyName = "ProductName";
            this.PeoductName.HeaderText = "Product Name";
            this.PeoductName.Name = "PeoductName";
            this.PeoductName.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "Manufacturer";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // ManDate
            // 
            this.ManDate.DataPropertyName = "ManDate";
            this.ManDate.HeaderText = "Manufacture Date";
            this.ManDate.Name = "ManDate";
            this.ManDate.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Last Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Availability
            // 
            this.Availability.DataPropertyName = "Availability";
            this.Availability.HeaderText = "Availibility";
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ProductsGridView);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 631);
            this.panel1.TabIndex = 2;
            // 
            // ProductsGrid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.panel1);
            this.Name = "ProductsGrid";
            this.Load += new System.EventHandler(this.ProductsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ProductsGridView;
        private DataGridViewTextBoxColumn ModelId;
        private DataGridViewTextBoxColumn PeoductName;
        private DataGridViewTextBoxColumn Manufacturer;
        private DataGridViewTextBoxColumn ManDate;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Availability;
        private Panel panel1;
    }
}
