using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGBookRental
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text));
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            try
            {
                dbDataSetTableAdapters.usersTableAdapter user = new dbDataSetTableAdapters.usersTableAdapter();
                dbDataSet.usersDataTable dt = user.GetDataByloginpass(textBox1.Text, textBox2.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Please enter username and password");
                }
                else
                {
                    MessageBox.Show("Please enter username and password");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
