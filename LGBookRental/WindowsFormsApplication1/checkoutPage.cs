using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class checkoutPage : Form
    {
        private Order currentOrder;
        public checkoutPage(Order currentOrder)
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
                orderConfirmationPage frm = new orderConfirmationPage(currentOrder);
                frm.Show();
                this.Hide();
            }
        }

        private void editOrder_Click(object sender, EventArgs e)
        {

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
