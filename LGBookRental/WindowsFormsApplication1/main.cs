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
    public partial class main : Form
    {
        public main()
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
                    MessageBox.Show("You logged in!");
                    currentUser = new User(textBox1.Text, textBox2.Text);
                    app frm = new app();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a correct username and password");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
