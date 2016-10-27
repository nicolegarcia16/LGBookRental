using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGBookRentals
{
    public partial class orderConfirmationPage : Form
    {
        Order currentOrder;
        User currentUser;
        public orderConfirmationPage(Order currentOrder, User currentUser)
        {
            this.currentOrder = currentOrder;
            this.currentUser = currentUser;
            InitializeComponent();
            orderLabel.Text = ("Order Information: \n Book Name: "
                            + currentOrder.bookRented.bookName
                            + "\n Book Id: "
                            + currentOrder.bookRented.bookId
                            + "\n Rental Length: "
                            + currentOrder.rentalLength
                            + "\n Total Due: "
                            + currentOrder.orderTotal
                            + "\n Shipping Address: "
                            + currentOrder.shippingAddress
                            + "\n Credit Card Number: "
                            + currentOrder.displayCreditCardNumber);
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            checkoutPage frm = new checkoutPage(currentOrder, currentUser);
            frm.Show();
            this.Hide();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
