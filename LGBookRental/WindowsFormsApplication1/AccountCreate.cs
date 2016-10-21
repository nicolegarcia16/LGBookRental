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
    public partial class AccountCreate : Form
    {
        public AccountCreate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main frm = new main();
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

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
