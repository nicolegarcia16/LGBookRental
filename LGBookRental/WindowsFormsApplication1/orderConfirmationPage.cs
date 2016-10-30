using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


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


            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

            //MAKE SURE TO CHANGE THE DB LOCATION TO YOUR DIRECTORY
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        @"Data source= C:\Users\Masters PC\Desktop\SSE657 Object oriented design\LGBookRental\LGBookRental\WindowsFormsApplication1\db.mdb";

            try
            {
                conn.Open();

                String my_querry = "INSERT INTO orders (ordernumber) VALUES('"+123456+"')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("order placed successfuly...!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                conn.Close();
            }




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
