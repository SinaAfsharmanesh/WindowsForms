using System.Windows.Forms;

namespace WindowsForms.UI
{
    partial class Calc
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
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.TxtBoxNum1 = new System.Windows.Forms.TextBox();
            this.TxtBoxNum2 = new System.Windows.Forms.TextBox();
            this.LabelNum1 = new System.Windows.Forms.Label();
            this.LabelNum2 = new System.Windows.Forms.Label();
            this.LabelRes = new System.Windows.Forms.Label();
            this.LabelShowRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSub
            // 
            this.BtnSub.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSub.Location = new System.Drawing.Point(145, 100);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(40, 35);
            this.BtnSub.TabIndex = 0;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMult.Location = new System.Drawing.Point(85, 141);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(40, 35);
            this.BtnMult.TabIndex = 1;
            this.BtnMult.Text = "×";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // BtnSum
            // 
            this.BtnSum.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSum.Location = new System.Drawing.Point(85, 100);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(40, 35);
            this.BtnSum.TabIndex = 2;
            this.BtnSum.Text = "+";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDiv.Location = new System.Drawing.Point(145, 141);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(40, 35);
            this.BtnDiv.TabIndex = 3;
            this.BtnDiv.Text = "÷";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // TxtBoxNum1
            // 
            this.TxtBoxNum1.Location = new System.Drawing.Point(85, 22);
            this.TxtBoxNum1.Name = "TxtBoxNum1";
            this.TxtBoxNum1.Size = new System.Drawing.Size(100, 25);
            this.TxtBoxNum1.TabIndex = 4;
            // 
            // TxtBoxNum2
            // 
            this.TxtBoxNum2.Location = new System.Drawing.Point(85, 53);
            this.TxtBoxNum2.Name = "TxtBoxNum2";
            this.TxtBoxNum2.Size = new System.Drawing.Size(100, 25);
            this.TxtBoxNum2.TabIndex = 5;
            // 
            // LabelNum1
            // 
            this.LabelNum1.AutoSize = true;
            this.LabelNum1.Location = new System.Drawing.Point(12, 30);
            this.LabelNum1.Name = "LabelNum1";
            this.LabelNum1.Size = new System.Drawing.Size(70, 17);
            this.LabelNum1.TabIndex = 6;
            this.LabelNum1.Text = "Number 1:";
            // 
            // LabelNum2
            // 
            this.LabelNum2.AutoSize = true;
            this.LabelNum2.Location = new System.Drawing.Point(12, 61);
            this.LabelNum2.Name = "LabelNum2";
            this.LabelNum2.Size = new System.Drawing.Size(70, 17);
            this.LabelNum2.TabIndex = 7;
            this.LabelNum2.Text = "Number 2:";
            // 
            // LabelRes
            // 
            this.LabelRes.AutoSize = true;
            this.LabelRes.Location = new System.Drawing.Point(32, 196);
            this.LabelRes.Name = "LabelRes";
            this.LabelRes.Size = new System.Drawing.Size(50, 17);
            this.LabelRes.TabIndex = 8;
            this.LabelRes.Text = "Result :";
            // 
            // LabelShowRes
            // 
            this.LabelShowRes.AutoSize = true;
            this.LabelShowRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelShowRes.ForeColor = System.Drawing.Color.DarkGreen;
            this.LabelShowRes.Location = new System.Drawing.Point(88, 196);
            this.LabelShowRes.Name = "LabelShowRes";
            this.LabelShowRes.Size = new System.Drawing.Size(0, 21);
            this.LabelShowRes.TabIndex = 9;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 284);
            this.Controls.Add(this.LabelShowRes);
            this.Controls.Add(this.LabelRes);
            this.Controls.Add(this.LabelNum2);
            this.Controls.Add(this.LabelNum1);
            this.Controls.Add(this.TxtBoxNum2);
            this.Controls.Add(this.TxtBoxNum1);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnSub);
            this.Name = "Calc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnSub;
        private Button BtnMult;
        private Button BtnSum;
        private Button BtnDiv;
        private TextBox TxtBoxNum1;
        private TextBox TxtBoxNum2;
        private Label LabelNum1;
        private Label LabelNum2;
        private Label LabelRes;
        private Label LabelShowRes;
    }
}