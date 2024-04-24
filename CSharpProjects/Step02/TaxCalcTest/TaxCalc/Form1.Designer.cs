namespace TaxCalc {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtotalTB = new System.Windows.Forms.TextBox();
            this.taxTB = new System.Windows.Forms.TextBox();
            this.grandTotalTB = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grand Total:";
            // 
            // subtotalTB
            // 
            this.subtotalTB.Enabled = false;
            this.subtotalTB.Location = new System.Drawing.Point(232, 46);
            this.subtotalTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subtotalTB.Name = "subtotalTB";
            this.subtotalTB.Size = new System.Drawing.Size(132, 22);
            this.subtotalTB.TabIndex = 3;
            this.subtotalTB.TextChanged += new System.EventHandler(this.subtotalTB_TextChanged);
            // 
            // taxTB
            // 
            this.taxTB.Enabled = false;
            this.taxTB.Location = new System.Drawing.Point(232, 85);
            this.taxTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taxTB.Name = "taxTB";
            this.taxTB.Size = new System.Drawing.Size(132, 22);
            this.taxTB.TabIndex = 4;
            // 
            // grandTotalTB
            // 
            this.grandTotalTB.Enabled = false;
            this.grandTotalTB.Location = new System.Drawing.Point(232, 127);
            this.grandTotalTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grandTotalTB.Name = "grandTotalTB";
            this.grandTotalTB.Size = new System.Drawing.Size(132, 22);
            this.grandTotalTB.TabIndex = 5;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(232, 180);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(133, 28);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Calc Tax";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 257);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.grandTotalTB);
            this.Controls.Add(this.taxTB);
            this.Controls.Add(this.subtotalTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subtotalTB;
        private System.Windows.Forms.TextBox taxTB;
        private System.Windows.Forms.TextBox grandTotalTB;
        private System.Windows.Forms.Button calcBtn;
    }
}

