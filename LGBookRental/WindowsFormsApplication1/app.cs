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
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();


            Book b1 = new Book(547628, "UML Patterns", 4799);


            booklist.Items.Add(b1.bookName);


            if (booklist.Text == "UML Patterns")
            {
                bookprice.Text = Convert.ToString(b1.rentalPrice);
            }

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main frm = new main();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void placeorderbtn_Click(object sender, EventArgs e)
        {

        }

        private void booklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
