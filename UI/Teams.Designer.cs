namespace WindowsForms.UI
{
    partial class Teams
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.checkVip = new System.Windows.Forms.CheckBox();
            this.DOBPick = new System.Windows.Forms.DateTimePicker();
            this.teamMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamMembersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ListBoxRed = new System.Windows.Forms.ListBox();
            this.listBoxBlue = new System.Windows.Forms.ListBox();
            this.teamMembersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ListTeams = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(95, 12);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(283, 25);
            this.txtBoxFirstName.TabIndex = 3;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(95, 43);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(283, 25);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // checkVip
            // 
            this.checkVip.AutoSize = true;
            this.checkVip.Location = new System.Drawing.Point(95, 141);
            this.checkVip.Name = "checkVip";
            this.checkVip.Size = new System.Drawing.Size(45, 21);
            this.checkVip.TabIndex = 6;
            this.checkVip.Text = "VIP";
            this.checkVip.UseVisualStyleBackColor = true;
            // 
            // DOBPick
            // 
            this.DOBPick.Location = new System.Drawing.Point(95, 74);
            this.DOBPick.Name = "DOBPick";
            this.DOBPick.Size = new System.Drawing.Size(283, 25);
            this.DOBPick.TabIndex = 7;
            // 
            // teamMembersBindingSource
            // 
            this.teamMembersBindingSource.DataSource = typeof(WindowsForms.Model.TeamMembers);
            // 
            // teamMembersBindingSource1
            // 
            this.teamMembersBindingSource1.DataSource = typeof(WindowsForms.Model.TeamMembers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Teams";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(95, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(25, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Members";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(25, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Members";
            // 
            // ListBoxRed
            // 
            this.ListBoxRed.FormattingEnabled = true;
            this.ListBoxRed.ItemHeight = 17;
            this.ListBoxRed.Location = new System.Drawing.Point(95, 218);
            this.ListBoxRed.Name = "ListBoxRed";
            this.ListBoxRed.Size = new System.Drawing.Size(283, 89);
            this.ListBoxRed.TabIndex = 14;
            // 
            // listBoxBlue
            // 
            this.listBoxBlue.FormattingEnabled = true;
            this.listBoxBlue.ItemHeight = 17;
            this.listBoxBlue.Location = new System.Drawing.Point(95, 313);
            this.listBoxBlue.Name = "listBoxBlue";
            this.listBoxBlue.Size = new System.Drawing.Size(283, 89);
            this.listBoxBlue.TabIndex = 15;
            // 
            // teamMembersBindingSource2
            // 
            this.teamMembersBindingSource2.DataSource = typeof(WindowsForms.Model.TeamMembers);
            // 
            // ListTeams
            // 
            this.ListTeams.FormattingEnabled = true;
            this.ListTeams.Location = new System.Drawing.Point(95, 105);
            this.ListTeams.Name = "ListTeams";
            this.ListTeams.Size = new System.Drawing.Size(121, 25);
            this.ListTeams.TabIndex = 16;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.ListTeams);
            this.Controls.Add(this.listBoxBlue);
            this.Controls.Add(this.ListBoxRed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DOBPick);
            this.Controls.Add(this.checkVip);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxLastName;
        private CheckBox checkVip;
        private DateTimePicker DOBPick;
        private Label label4;
        private Button btnAdd;
        private Label label6;
        private Label label7;
        private ListBox ListBoxRed;
        private ListBox listBoxBlue;
        private BindingSource teamMembersBindingSource;
        private BindingSource teamMembersBindingSource1;
        private BindingSource teamMembersBindingSource2;
        private ComboBox ListTeams;
    }
}