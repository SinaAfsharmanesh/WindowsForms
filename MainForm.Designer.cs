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
            this.BtnAddPrdct = new System.Windows.Forms.Button();
            this.BtnShowUsers = new System.Windows.Forms.Button();
            this.BtnShowCalc = new System.Windows.Forms.Button();
            this.ListPrdct = new System.Windows.Forms.ListBox();
            this.TxtBoxAddPrdct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAddPrdct
            // 
            this.BtnAddPrdct.Location = new System.Drawing.Point(255, 12);
            this.BtnAddPrdct.Name = "BtnAddPrdct";
            this.BtnAddPrdct.Size = new System.Drawing.Size(75, 23);
            this.BtnAddPrdct.TabIndex = 0;
            this.BtnAddPrdct.Text = "Add";
            this.BtnAddPrdct.UseVisualStyleBackColor = true;
            this.BtnAddPrdct.Click += new System.EventHandler(this.BtnAddPrdct_Click);
            // 
            // BtnShowUsers
            // 
            this.BtnShowUsers.Location = new System.Drawing.Point(12, 408);
            this.BtnShowUsers.Name = "BtnShowUsers";
            this.BtnShowUsers.Size = new System.Drawing.Size(120, 23);
            this.BtnShowUsers.TabIndex = 1;
            this.BtnShowUsers.Text = "Show Users";
            this.BtnShowUsers.UseVisualStyleBackColor = true;
            // 
            // BtnShowCalc
            // 
            this.BtnShowCalc.Location = new System.Drawing.Point(211, 408);
            this.BtnShowCalc.Name = "BtnShowCalc";
            this.BtnShowCalc.Size = new System.Drawing.Size(120, 23);
            this.BtnShowCalc.TabIndex = 2;
            this.BtnShowCalc.Text = "Show Calculator";
            this.BtnShowCalc.UseVisualStyleBackColor = true;
            this.BtnShowCalc.Click += new System.EventHandler(this.BtnShowCalc_Click);
            // 
            // ListPrdct
            // 
            this.ListPrdct.FormattingEnabled = true;
            this.ListPrdct.ItemHeight = 17;
            this.ListPrdct.Location = new System.Drawing.Point(12, 41);
            this.ListPrdct.Name = "ListPrdct";
            this.ListPrdct.Size = new System.Drawing.Size(319, 361);
            this.ListPrdct.TabIndex = 3;
            // 
            // TxtBoxAddPrdct
            // 
            this.TxtBoxAddPrdct.Location = new System.Drawing.Point(12, 12);
            this.TxtBoxAddPrdct.Name = "TxtBoxAddPrdct";
            this.TxtBoxAddPrdct.Size = new System.Drawing.Size(237, 25);
            this.TxtBoxAddPrdct.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 439);
            this.Controls.Add(this.TxtBoxAddPrdct);
            this.Controls.Add(this.ListPrdct);
            this.Controls.Add(this.BtnShowCalc);
            this.Controls.Add(this.BtnShowUsers);
            this.Controls.Add(this.BtnAddPrdct);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAddPrdct;
        private Button BtnShowUsers;
        private Button BtnShowCalc;
        private ListBox ListPrdct;
        private TextBox TxtBoxAddPrdct;
    }
}