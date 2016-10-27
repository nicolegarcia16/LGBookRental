namespace LGBookRentals
{
    partial class checkoutPage
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
            this.placeOrder = new System.Windows.Forms.Button();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.shippingAddress = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.shippingAddressLabel = new System.Windows.Forms.Label();
            this.shippingCityLabel = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.shippingStateLabel = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.shippingZipLabel = new System.Windows.Forms.Label();
            this.creditCardNumber = new System.Windows.Forms.TextBox();
            this.creditCardNumberLabel = new System.Windows.Forms.Label();
            this.nameOnCreditCard = new System.Windows.Forms.TextBox();
            this.creditCardNameLabel = new System.Windows.Forms.Label();
            this.creditCardExpirationDate = new System.Windows.Forms.TextBox();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.creditCardCVVCode = new System.Windows.Forms.TextBox();
            this.cvvLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.orderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderLabel.Location = new System.Drawing.Point(13, 13);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(128, 90);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "Order Information:\r\nBook Name:\r\nBook Id:\r\nRental Length:\r\nPrice:\r\n";
            this.orderLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // placeOrder
            // 
            this.placeOrder.Location = new System.Drawing.Point(16, 216);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(99, 32);
            this.placeOrder.TabIndex = 1;
            this.placeOrder.Text = "Place Order";
            this.placeOrder.UseVisualStyleBackColor = true;
            this.placeOrder.Click += new System.EventHandler(this.placeOrder_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(16, 171);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(99, 32);
            this.goBackBtn.TabIndex = 2;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.editOrder_Click);
            // 
            // shippingAddress
            // 
            this.shippingAddress.Location = new System.Drawing.Point(249, 49);
            this.shippingAddress.Name = "shippingAddress";
            this.shippingAddress.Size = new System.Drawing.Size(294, 22);
            this.shippingAddress.TabIndex = 3;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(249, 93);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(116, 22);
            this.city.TabIndex = 4;
            // 
            // shippingAddressLabel
            // 
            this.shippingAddressLabel.AutoSize = true;
            this.shippingAddressLabel.Location = new System.Drawing.Point(246, 29);
            this.shippingAddressLabel.Name = "shippingAddressLabel";
            this.shippingAddressLabel.Size = new System.Drawing.Size(119, 17);
            this.shippingAddressLabel.TabIndex = 5;
            this.shippingAddressLabel.Text = "Shipping Address";
            // 
            // shippingCityLabel
            // 
            this.shippingCityLabel.AutoSize = true;
            this.shippingCityLabel.Location = new System.Drawing.Point(246, 74);
            this.shippingCityLabel.Name = "shippingCityLabel";
            this.shippingCityLabel.Size = new System.Drawing.Size(31, 17);
            this.shippingCityLabel.TabIndex = 6;
            this.shippingCityLabel.Text = "City";
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(371, 93);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(63, 22);
            this.state.TabIndex = 7;
            // 
            // shippingStateLabel
            // 
            this.shippingStateLabel.AutoSize = true;
            this.shippingStateLabel.Location = new System.Drawing.Point(371, 74);
            this.shippingStateLabel.Name = "shippingStateLabel";
            this.shippingStateLabel.Size = new System.Drawing.Size(41, 17);
            this.shippingStateLabel.TabIndex = 8;
            this.shippingStateLabel.Text = "State";
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(440, 93);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(103, 22);
            this.zipCode.TabIndex = 9;
            // 
            // shippingZipLabel
            // 
            this.shippingZipLabel.AutoSize = true;
            this.shippingZipLabel.Location = new System.Drawing.Point(437, 74);
            this.shippingZipLabel.Name = "shippingZipLabel";
            this.shippingZipLabel.Size = new System.Drawing.Size(65, 17);
            this.shippingZipLabel.TabIndex = 10;
            this.shippingZipLabel.Text = "Zip Code";
            // 
            // creditCardNumber
            // 
            this.creditCardNumber.Location = new System.Drawing.Point(249, 138);
            this.creditCardNumber.Name = "creditCardNumber";
            this.creditCardNumber.Size = new System.Drawing.Size(294, 22);
            this.creditCardNumber.TabIndex = 11;
            // 
            // creditCardNumberLabel
            // 
            this.creditCardNumberLabel.AutoSize = true;
            this.creditCardNumberLabel.Location = new System.Drawing.Point(246, 118);
            this.creditCardNumberLabel.Name = "creditCardNumberLabel";
            this.creditCardNumberLabel.Size = new System.Drawing.Size(133, 17);
            this.creditCardNumberLabel.TabIndex = 12;
            this.creditCardNumberLabel.Text = "Credit Card Number";
            // 
            // nameOnCreditCard
            // 
            this.nameOnCreditCard.Location = new System.Drawing.Point(249, 181);
            this.nameOnCreditCard.Name = "nameOnCreditCard";
            this.nameOnCreditCard.Size = new System.Drawing.Size(294, 22);
            this.nameOnCreditCard.TabIndex = 13;
            // 
            // creditCardNameLabel
            // 
            this.creditCardNameLabel.AutoSize = true;
            this.creditCardNameLabel.Location = new System.Drawing.Point(246, 163);
            this.creditCardNameLabel.Name = "creditCardNameLabel";
            this.creditCardNameLabel.Size = new System.Drawing.Size(143, 17);
            this.creditCardNameLabel.TabIndex = 14;
            this.creditCardNameLabel.Text = "Name On Credit Card";
            // 
            // creditCardExpirationDate
            // 
            this.creditCardExpirationDate.Location = new System.Drawing.Point(249, 226);
            this.creditCardExpirationDate.Name = "creditCardExpirationDate";
            this.creditCardExpirationDate.Size = new System.Drawing.Size(116, 22);
            this.creditCardExpirationDate.TabIndex = 15;
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Location = new System.Drawing.Point(246, 206);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(104, 17);
            this.expirationDateLabel.TabIndex = 16;
            this.expirationDateLabel.Text = "Expiration Date";
            // 
            // creditCardCVVCode
            // 
            this.creditCardCVVCode.Location = new System.Drawing.Point(371, 226);
            this.creditCardCVVCode.Name = "creditCardCVVCode";
            this.creditCardCVVCode.Size = new System.Drawing.Size(72, 22);
            this.creditCardCVVCode.TabIndex = 17;
            // 
            // cvvLabel
            // 
            this.cvvLabel.AutoSize = true;
            this.cvvLabel.Location = new System.Drawing.Point(371, 206);
            this.cvvLabel.Name = "cvvLabel";
            this.cvvLabel.Size = new System.Drawing.Size(72, 17);
            this.cvvLabel.TabIndex = 18;
            this.cvvLabel.Text = "CVV Code";
            // 
            // checkoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.cvvLabel);
            this.Controls.Add(this.creditCardCVVCode);
            this.Controls.Add(this.expirationDateLabel);
            this.Controls.Add(this.creditCardExpirationDate);
            this.Controls.Add(this.creditCardNameLabel);
            this.Controls.Add(this.nameOnCreditCard);
            this.Controls.Add(this.creditCardNumberLabel);
            this.Controls.Add(this.creditCardNumber);
            this.Controls.Add(this.shippingZipLabel);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.shippingStateLabel);
            this.Controls.Add(this.state);
            this.Controls.Add(this.shippingCityLabel);
            this.Controls.Add(this.shippingAddressLabel);
            this.Controls.Add(this.city);
            this.Controls.Add(this.shippingAddress);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.placeOrder);
            this.Controls.Add(this.orderLabel);
            this.Name = "checkoutPage";
            this.Text = "Order Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button placeOrder;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.TextBox shippingAddress;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label shippingAddressLabel;
        private System.Windows.Forms.Label shippingCityLabel;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label shippingStateLabel;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.Label shippingZipLabel;
        private System.Windows.Forms.TextBox creditCardNumber;
        private System.Windows.Forms.Label creditCardNumberLabel;
        private System.Windows.Forms.TextBox nameOnCreditCard;
        private System.Windows.Forms.Label creditCardNameLabel;
        private System.Windows.Forms.TextBox creditCardExpirationDate;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.TextBox creditCardCVVCode;
        private System.Windows.Forms.Label cvvLabel;
    }
}