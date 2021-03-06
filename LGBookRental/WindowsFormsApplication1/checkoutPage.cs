﻿using System;
using System.Windows.Forms;

namespace LGBookRentals
{
    public partial class checkoutPage : Form
    {
        private Order currentOrder;
        private User currentUser;
        public checkoutPage(Order currentOrder, User currentUser)
        {
            InitializeComponent();
            orderLabel.Text = ("Order Information: \n Book Name: "
                                + currentOrder.bookRented.bookName
                                + "\n Book Id: "
                                + currentOrder.bookRented.bookId
                                + "\n Rental Length: "
                                + currentOrder.rentalLength
                                + "\n Total Due: "
                                + currentOrder.orderTotal);
            this.currentOrder = currentOrder;
            this.currentUser = currentUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Do nothing, but it gives me errors if I take this out.
        }

        public Order addShippingAndPaymentInfo(Order currentOrder, string shippingAddress, string creditCardNumber)
        {
            currentOrder.shippingAddress = shippingAddress;
            currentOrder.creditCardNumber = creditCardNumber;
            return currentOrder;
        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            if (shippingAddress.Text.Length == 0 && creditCardNumber.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Shipping and Payment Information");
            }
            else if (shippingAddress.Text.Length == 0)
            {
                MessageBox.Show("Please Enter a Shipping Address");
            }
            else if (creditCardNumber.Text.Length == 0)
            {
                MessageBox.Show("Please Enter your Payment Information");
            }
            else
            {
                currentOrder = addShippingAndPaymentInfo(currentOrder, shippingAddress.Text, creditCardNumber.Text);
                currentOrder = createAndAddDisplayCreditCardNumber(currentOrder);
                orderConfirmationPage frm = new orderConfirmationPage(currentOrder, currentUser);
                frm.Show();
                this.Hide();
            }
        }

        private void editOrder_Click(object sender, EventArgs e)
        {
            availableBooksPage frm = new availableBooksPage(currentUser);
            frm.Show();
            this.Hide();
        }

        public string createDisplayCreditCardNumber(string creditCardNumber)
        {
            int numberLength = creditCardNumber.Length;
            string displayCreditCardNumber = creditCardNumber.Substring(numberLength - 4);
            displayCreditCardNumber = displayCreditCardNumber.PadLeft(numberLength, '*');
            return displayCreditCardNumber;
        }

        public Order addDisplayCreditCardNumberToOrder(Order currentOrder, string displayCreditCardNumber)
        {
            currentOrder.displayCreditCardNumber = displayCreditCardNumber;
            return currentOrder;
        }

        public Order createAndAddDisplayCreditCardNumber(Order currentOrder)
        {
            string displayNumber = createDisplayCreditCardNumber(currentOrder.creditCardNumber);
            currentOrder = addDisplayCreditCardNumberToOrder(currentOrder, displayNumber);
            return currentOrder;
        }
    }
}
