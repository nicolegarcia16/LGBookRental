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
    public partial class availableBooksPage : Form
    {
        // Aqui puedes poner class attributes. 
        private List<Book> availableBooks;

        public availableBooksPage()
        {
            InitializeComponent();

            availableBooks = addAvailableBooks();

            //Book b1 = new Book(547628, "UML Patterns", 4799);

            BindingSource bookSource = new BindingSource();
            bookSource.DataSource = availableBooks;
            booklist.DataSource = bookSource.DataSource;
            booklist.DisplayMember = "bookName";
            booklist.ValueMember = "rentalPrice";

            //booklist.Items.Add(b1.bookName);

            // readonly! dame un break lol
            //booklist.

       


        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginPage frm = new loginPage();
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
            Book selectedBook = (Book)booklist.SelectedItem;
            Order currentOrder = createNewOrder(selectedBook, int.Parse(RentalLenght.Text));
            checkoutPage frm = new checkoutPage(currentOrder);
            frm.Show();
            this.Hide();
        }

        private void booklist_SelectedIndexChanged(object sender, EventArgs e)
        {

            bookprice.Text = ((Book)booklist.SelectedItem).rentalPrice.ToString();
            Bookname.Text = ((Book)booklist.SelectedItem).bookName.ToString();

            if (Bookname.Text == "UML Patterns")
            {
                bookpicture.Image = Image.FromFile("img/uml.jpg");
            }
            else
            {
                bookpicture.Image = Image.FromFile("img/Book.png");
            }
        }

        public List<Book> addAvailableBooks()
        {
            availableBooks = new List<Book>();
            availableBooks.Add(new Book(547628, "UML Patterns", 47.99));
            availableBooks.Add(new Book(2, "Test Patterns", 12.99));
            return availableBooks;
        }

        public Order createNewOrder(Book selectedBook, int rentalLength)
        {
            Order newOrder = new Order(selectedBook.bookName, selectedBook.bookId, rentalLength, selectedBook.rentalPrice);
            return newOrder;
        }
    }
}
