using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LGBookRentals
{
    public partial class AccountCreate : Form
    {
        public AccountCreate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginPage frm = new loginPage();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordtextbox.Text != passwordconfirmtextbox.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            var emptyTextboxes = from tb in this.Controls.OfType<TextBox>()
                                 where string.IsNullOrEmpty(tb.Text)
                                 select tb;
            if (emptyTextboxes.Any())
            {
                MessageBox.Show("One or more fields is empty");
            }
            else
            {
                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

                //MAKE SURE TO CHANGE THE DB LOCATION TO YOUR DIRECTORY
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data source= C:\Users\nicol\Source\Repos\LGBookRental\LGBookRental\WindowsFormsApplication1\db.mdb";

                try
                {
                    conn.Open();

                    String my_querry = "INSERT INTO users (login,pass,firstname,lastname,address,city,state,zipcode,phone) VALUES('" + emailtextbox.Text + "','" + passwordtextbox.Text + "','" + Nametextbox.Text + "','" + lastnametextbox.Text + "','" + addresstextbox.Text + "','" + citytextbox.Text + "','" + statetextbox.Text + "','" + ziptextbox.Text + "','" + phonetextbox.Text + "')";

                    OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data saved successfuly...!");
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
