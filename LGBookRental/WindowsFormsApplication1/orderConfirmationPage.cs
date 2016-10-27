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
    public partial class orderConfirmationPage : Form
    {
        Order currentOrder;
        public orderConfirmationPage(Order currentOrder)
        {
            this.currentOrder = currentOrder;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
