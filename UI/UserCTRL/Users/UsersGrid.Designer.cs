namespace WindowsForms.UI.UserCTRL.Users
{
    partial class UsersGrid
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
            this.components = new System.ComponentModel.Container();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersGridView
            // 
            this.UsersGridView.AllowUserToAddRows = false;
            this.UsersGridView.AllowUserToDeleteRows = false;
            this.UsersGridView.AllowUserToOrderColumns = true;
            this.UsersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))));
            this.UsersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.firstname,
            this.lastname,
            this.NatId,
            this.dob,
            this.email,
            this.address,
            this.active});
            this.UsersGridView.GridColor = System.Drawing.Color.Black;
            this.UsersGridView.Location = new System.Drawing.Point(0, 0);
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.RowTemplate.Height = 27;
            this.UsersGridView.Size = new System.Drawing.Size(914, 631);
            this.UsersGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 20F;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "FirstName";
            this.firstname.FillWeight = 53.94378F;
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "LastName";
            this.lastname.FillWeight = 53.94378F;
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // NatId
            // 
            this.NatId.DataPropertyName = "NatID";
            this.NatId.FillWeight = 53.94378F;
            this.NatId.HeaderText = "National ID";
            this.NatId.Name = "NatId";
            this.NatId.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "DOB";
            this.dob.FillWeight = 53.94378F;
            this.dob.HeaderText = "Date Of Birth";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.FillWeight = 53.94378F;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.FillWeight = 53.94378F;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // active
            // 
            this.active.DataPropertyName = "IsActive";
            this.active.FillWeight = 40F;
            this.active.HeaderText = "Is Active";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            // 
            // dBContextBindingSource
            // 
            this.dBContextBindingSource.DataSource = typeof(WindowsForms.InternalDB.DBContext);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 631);
            this.panel1.TabIndex = 1;
            // 
            // UsersGrid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.UsersGridView);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UsersGrid";
            this.Size = new System.Drawing.Size(917, 634);
            this.Load += new System.EventHandler(this.UsersGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView UsersGridView;
        private BindingSource dBContextBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn NatId;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn active;
        private Panel panel1;
    }
}
