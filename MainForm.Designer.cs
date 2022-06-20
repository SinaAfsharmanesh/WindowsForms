namespace WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTeams = new System.Windows.Forms.Button();
            this.UserGrid = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeams
            // 
            this.btnTeams.Location = new System.Drawing.Point(230, 12);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(102, 42);
            this.btnTeams.TabIndex = 5;
            this.btnTeams.Text = "Show Team members";
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // UserGrid
            // 
            this.UserGrid.Location = new System.Drawing.Point(12, 12);
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.Size = new System.Drawing.Size(102, 42);
            this.UserGrid.TabIndex = 7;
            this.UserGrid.Text = "User Grid";
            this.UserGrid.UseVisualStyleBackColor = true;
            this.UserGrid.Click += new System.EventHandler(this.UserGrid_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(12, 60);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(102, 42);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 459);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.UserGrid);
            this.Controls.Add(this.btnTeams);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnTeams;
        private Button UserGrid;
        private Button btnAddUser;
    }
}