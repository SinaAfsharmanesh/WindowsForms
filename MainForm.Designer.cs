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
            this.boxProducts = new System.Windows.Forms.CheckBox();
            this.boxUsers = new System.Windows.Forms.CheckBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripDbName = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.panel.Controls.Add(this.boxProducts);
            this.panel.Controls.Add(this.boxUsers);
            this.panel.Location = new System.Drawing.Point(914, 24);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(150, 631);
            this.panel.TabIndex = 0;
            // 
            // boxProducts
            // 
            this.boxProducts.Appearance = System.Windows.Forms.Appearance.Button;
            this.boxProducts.FlatAppearance.BorderSize = 0;
            this.boxProducts.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))));
            this.boxProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxProducts.Font = new System.Drawing.Font("Nunito Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxProducts.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.boxProducts.Location = new System.Drawing.Point(0, 50);
            this.boxProducts.Margin = new System.Windows.Forms.Padding(0);
            this.boxProducts.Name = "boxProducts";
            this.boxProducts.Size = new System.Drawing.Size(150, 50);
            this.boxProducts.TabIndex = 3;
            this.boxProducts.Text = "Products";
            this.boxProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boxProducts.UseVisualStyleBackColor = true;
            this.boxProducts.Click += new System.EventHandler(this.boxProducts_Click);
            // 
            // boxUsers
            // 
            this.boxUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.boxUsers.FlatAppearance.BorderSize = 0;
            this.boxUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))));
            this.boxUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxUsers.Font = new System.Drawing.Font("Nunito Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxUsers.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.boxUsers.Location = new System.Drawing.Point(0, 0);
            this.boxUsers.Margin = new System.Windows.Forms.Padding(0);
            this.boxUsers.Name = "boxUsers";
            this.boxUsers.Size = new System.Drawing.Size(150, 50);
            this.boxUsers.TabIndex = 2;
            this.boxUsers.Text = "Users";
            this.boxUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boxUsers.UseVisualStyleBackColor = true;
            this.boxUsers.Click += new System.EventHandler(this.boxUsers_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersListToolStripMenuItem,
            this.productsListToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1064, 26);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // usersListToolStripMenuItem
            // 
            this.usersListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.usersListToolStripMenuItem.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
            this.usersListToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.usersListToolStripMenuItem.Text = "Users";
            this.usersListToolStripMenuItem.DropDownClosed += new System.EventHandler(this.usersListToolStripMenuItem_DropDownClosed);
            this.usersListToolStripMenuItem.DropDownOpened += new System.EventHandler(this.usersListToolStripMenuItem_DropDownOpened);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // productsListToolStripMenuItem
            // 
            this.productsListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.productsListToolStripMenuItem.Font = new System.Drawing.Font("Nunito SemiBold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productsListToolStripMenuItem.Name = "productsListToolStripMenuItem";
            this.productsListToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.productsListToolStripMenuItem.Text = "Products";
            this.productsListToolStripMenuItem.DropDownClosed += new System.EventHandler(this.productsListToolStripMenuItem_DropDownClosed);
            this.productsListToolStripMenuItem.DropDownOpened += new System.EventHandler(this.productsListToolStripMenuItem_DropDownOpened);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDbName,
            this.toolStripProgressBar,
            this.toolStripProg});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 655);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1064, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripDbName
            // 
            this.toolStripDbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripDbName.Name = "toolStripDbName";
            this.toolStripDbName.Size = new System.Drawing.Size(60, 17);
            this.toolStripDbName.Text = "DbName";
            this.toolStripDbName.Click += new System.EventHandler(this.toolStripDbName_Click);
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
            this.panelMain.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem productsListToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem removeToolStripMenuItem1;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripDbName;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripStatusLabel toolStripProg;
        private Panel panelMain;
        private CheckBox boxUsers;
        private CheckBox boxProducts;
    }
}