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
            this.panel = new System.Windows.Forms.Panel();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProg = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel.Controls.Add(this.BtnProducts);
            this.panel.Controls.Add(this.BtnUsers);
            this.panel.Location = new System.Drawing.Point(914, 24);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(150, 631);
            this.panel.TabIndex = 0;
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.BtnProducts.FlatAppearance.BorderSize = 0;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("Nunito SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProducts.Location = new System.Drawing.Point(0, 51);
            this.BtnProducts.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(150, 50);
            this.BtnProducts.TabIndex = 1;
            this.BtnProducts.Text = "Products";
            this.BtnProducts.UseVisualStyleBackColor = false;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Nunito SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUsers.Location = new System.Drawing.Point(0, 0);
            this.BtnUsers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(150, 50);
            this.BtnUsers.TabIndex = 0;
            this.BtnUsers.Text = "Users";
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersListToolStripMenuItem,
            this.productsListToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // usersListToolStripMenuItem
            // 
            this.usersListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.usersListToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
            this.usersListToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.usersListToolStripMenuItem.Text = "Users";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // productsListToolStripMenuItem
            // 
            this.productsListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.productsListToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.productsListToolStripMenuItem.Name = "productsListToolStripMenuItem";
            this.productsListToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.productsListToolStripMenuItem.Text = "Products";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUserName,
            this.toolStripProgressBar,
            this.toolStripProg});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 655);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1064, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripUserName
            // 
            this.toolStripUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripUserName.Name = "toolStripUserName";
            this.toolStripUserName.Size = new System.Drawing.Size(70, 17);
            this.toolStripUserName.Text = "UserName";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.ForeColor = System.Drawing.Color.White;
            this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(100, 5, 0, 5);
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar.Value = 30;
            // 
            // toolStripProg
            // 
            this.toolStripProg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripProg.Name = "toolStripProg";
            this.toolStripProg.Size = new System.Drawing.Size(59, 17);
            this.toolStripProg.Text = "Ongoing";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(914, 631);
            this.panelMain.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.TopMost = true;
            this.panel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem usersListToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem productsListToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem removeToolStripMenuItem1;
        private Button BtnUsers;
        private Button BtnProducts;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripUserName;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripStatusLabel toolStripProg;
        private Panel panelMain;
    }
}