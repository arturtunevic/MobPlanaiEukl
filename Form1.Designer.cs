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
            this.PlansDebugView = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlansDebugView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pageidaujamu min. sk.";
            // 
            // MinSkBox
            // 
            this.MinSkBox.Location = new System.Drawing.Point(20, 47);
            this.MinSkBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinSkBox.Name = "MinSkBox";
            this.MinSkBox.Size = new System.Drawing.Size(104, 20);
            this.MinSkBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pageidaujamu SMS sk.";
            // 
            // SmsBox
            // 
            this.SmsBox.Location = new System.Drawing.Point(168, 47);
            this.SmsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SmsBox.Name = "SmsBox";
            this.SmsBox.Size = new System.Drawing.Size(104, 20);
            this.SmsBox.TabIndex = 3;
            // 
            // NetGbBox
            // 
            this.NetGbBox.Location = new System.Drawing.Point(306, 47);
            this.NetGbBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NetGbBox.Name = "NetGbBox";
            this.NetGbBox.Size = new System.Drawing.Size(104, 20);
            this.NetGbBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pageidaujamas int. GB";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(453, 47);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(104, 20);
            this.PriceBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pageidaujama men. kaina eur";
            // 
            // FindPlanBtn
            // 
            this.FindPlanBtn.Location = new System.Drawing.Point(224, 85);
            this.FindPlanBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindPlanBtn.Name = "FindPlanBtn";
            this.FindPlanBtn.Size = new System.Drawing.Size(134, 61);
            this.FindPlanBtn.TabIndex = 9;
            this.FindPlanBtn.Text = "Rasti plana";
            this.FindPlanBtn.UseVisualStyleBackColor = true;
            this.FindPlanBtn.Click += new System.EventHandler(this.FindPlanBtn_Click);
            // 
            // PlansDebugView
            // 
            this.PlansDebugView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlansDebugView.Location = new System.Drawing.Point(2, 238);
            this.PlansDebugView.Name = "PlansDebugView";
            this.PlansDebugView.Size = new System.Drawing.Size(607, 87);
            this.PlansDebugView.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 337);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PlansDebugView);
            this.Controls.Add(this.FindPlanBtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NetGbBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SmsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinSkBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlansDebugView)).EndInit();
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
        private System.Windows.Forms.DataGridView PlansDebugView;
        private System.Windows.Forms.ListBox listBox1;
    }
}

