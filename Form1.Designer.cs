namespace MobPlanaiEuklidas
{
    partial class Form1
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
            this.MinSkBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SmsBox = new System.Windows.Forms.TextBox();
            this.NetGbBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindPlanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pageidaujamu min. sk.";
            // 
            // MinSkBox
            // 
            this.MinSkBox.Location = new System.Drawing.Point(41, 91);
            this.MinSkBox.Name = "MinSkBox";
            this.MinSkBox.Size = new System.Drawing.Size(204, 31);
            this.MinSkBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pageidaujamu SMS sk.";
            // 
            // SmsBox
            // 
            this.SmsBox.Location = new System.Drawing.Point(337, 91);
            this.SmsBox.Name = "SmsBox";
            this.SmsBox.Size = new System.Drawing.Size(204, 31);
            this.SmsBox.TabIndex = 3;
            // 
            // NetGbBox
            // 
            this.NetGbBox.Location = new System.Drawing.Point(611, 91);
            this.NetGbBox.Name = "NetGbBox";
            this.NetGbBox.Size = new System.Drawing.Size(204, 31);
            this.NetGbBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pageidaujamas int. GB";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(906, 91);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(204, 31);
            this.PriceBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(871, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pageidaujama men. kaina eur";
            // 
            // FindPlanBtn
            // 
            this.FindPlanBtn.Location = new System.Drawing.Point(449, 164);
            this.FindPlanBtn.Name = "FindPlanBtn";
            this.FindPlanBtn.Size = new System.Drawing.Size(267, 118);
            this.FindPlanBtn.TabIndex = 9;
            this.FindPlanBtn.Text = "Rasti plana";
            this.FindPlanBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 649);
            this.Controls.Add(this.FindPlanBtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NetGbBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SmsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinSkBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MinSkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SmsBox;
        private System.Windows.Forms.TextBox NetGbBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindPlanBtn;
    }
}

