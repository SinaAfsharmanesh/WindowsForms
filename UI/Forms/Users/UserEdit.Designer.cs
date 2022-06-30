namespace WindowsForms.UI
{
    partial class UserEdit
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxNatID = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(159, 242);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(159, 191);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker.TabIndex = 24;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(159, 160);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(200, 25);
            this.txtBoxEmail.TabIndex = 23;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(159, 129);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(200, 25);
            this.txtBoxAddress.TabIndex = 22;
            // 
            // txtBoxNatID
            // 
            this.txtBoxNatID.Location = new System.Drawing.Point(159, 98);
            this.txtBoxNatID.Name = "txtBoxNatID";
            this.txtBoxNatID.Size = new System.Drawing.Size(200, 25);
            this.txtBoxNatID.TabIndex = 21;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(159, 67);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(200, 25);
            this.txtBoxLastName.TabIndex = 20;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(159, 36);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(200, 25);
            this.txtBoxFirstName.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "National ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(130, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(23, 17);
            this.Label.TabIndex = 26;
            this.Label.Text = "ID:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(159, 9);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 17);
            this.IdLabel.TabIndex = 27;
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 358);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxNatID);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserEdit";
            this.Text = "UserEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSubmit;
        private DateTimePicker dateTimePicker;
        private TextBox txtBoxEmail;
        private TextBox txtBoxAddress;
        private TextBox txtBoxNatID;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Label;
        private Label IdLabel;
    }
}