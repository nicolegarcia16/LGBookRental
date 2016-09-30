using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGBookRental
{
    public class Order
    {
        public int orderNumber;
        public DateTime orderDate;
        public double orderTotal;
        public List<Book> booksRented;

        public Order()
        {
            booksRented = new List<Book>();
        }

        public string toString()
        {
            string booksString = "";
            foreach(Book book in booksRented)
            {
                booksString += " " + book.bookName;
            }
            return "Order Number: " + orderNumber + "\nOrder Date: " + orderDate +
                "\nOrder Total: " + orderTotal + "\nBooks Rented: " + booksString;
        }
    }

}
