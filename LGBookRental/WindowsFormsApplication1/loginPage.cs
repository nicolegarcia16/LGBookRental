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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter a username!");
                return;
            }

            try
            {
                dbDataSetTableAdapters.usersTableAdapter user = new dbDataSetTableAdapters.usersTableAdapter();
                User currentUser;
                dbDataSet.usersDataTable dt = user.GetDataByloginpass(textBox1.Text, textBox2.Text);
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("You logged in!");
                    currentUser = new User(textBox1.Text, textBox2.Text);
                    availableBooksPage frm = new availableBooksPage(currentUser);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            try
            {
            AccountCreate frm = new AccountCreate();
            frm.Show();
            this.Hide();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
