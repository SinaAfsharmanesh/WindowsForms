namespace WindowsForms
{
    partial class Login
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
            this.textServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDbName = new System.Windows.Forms.TextBox();
            this.checkBoxTrusted = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(120, 12);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(310, 25);
            this.textServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Databese Name";
            // 
            // textDbName
            // 
            this.textDbName.Location = new System.Drawing.Point(120, 43);
            this.textDbName.Name = "textDbName";
            this.textDbName.Size = new System.Drawing.Size(310, 25);
            this.textDbName.TabIndex = 3;
            // 
            // checkBoxTrusted
            // 
            this.checkBoxTrusted.AutoSize = true;
            this.checkBoxTrusted.Location = new System.Drawing.Point(120, 74);
            this.checkBoxTrusted.Name = "checkBoxTrusted";
            this.checkBoxTrusted.Size = new System.Drawing.Size(139, 21);
            this.checkBoxTrusted.TabIndex = 4;
            this.checkBoxTrusted.Text = "Trusted Connection";
            this.checkBoxTrusted.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(120, 125);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 183);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.checkBoxTrusted);
            this.Controls.Add(this.textDbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textServer;
        private Label label2;
        private TextBox textDbName;
        private CheckBox checkBoxTrusted;
        private Button btnConnect;
    }
}