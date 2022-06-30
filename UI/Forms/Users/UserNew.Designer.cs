namespace WindowsForms.UI
{
    partial class UserNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "National ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Of Birth";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 25);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 25);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 25);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(152, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 25);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(152, 147);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 25);
            this.textBox5.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(152, 229);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UserNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 362);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserNew";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private Button btnSubmit;
    }
}