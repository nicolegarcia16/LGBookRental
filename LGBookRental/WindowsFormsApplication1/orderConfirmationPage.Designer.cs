namespace LGBookRentals
{
    partial class orderConfirmationPage
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
            this.orderLabel = new System.Windows.Forms.Label();
            this.finishBtn = new System.Windows.Forms.Button();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderLabel
            // 
            this.orderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderLabel.AutoSize = true;
            this.orderLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.orderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.orderLabel.Location = new System.Drawing.Point(10, 9);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(148, 144);
            this.orderLabel.TabIndex = 1;
            this.orderLabel.Text = "Order Information:\r\nBook Name:\r\nBook Id:\r\nRental Length:\r\nPrice:\r\nShipping Addres" +
    "s:\r\n\r\nPayment Information:";
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(13, 205);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(99, 36);
            this.finishBtn.TabIndex = 2;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.AutoSize = true;
            this.goBackBtn.Location = new System.Drawing.Point(276, 205);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(99, 36);
            this.goBackBtn.TabIndex = 3;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // orderConfirmationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(387, 253);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.orderLabel);
            this.Name = "orderConfirmationPage";
            this.Text = "Confirm Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Button goBackBtn;
    }
}