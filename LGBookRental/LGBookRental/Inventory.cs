using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGBookRental
{
    public class Inventory
    {
        public List<Book> availableBooks = new List<Book>();       
        

        public void addBooks()
        {
            Book nb1 = new Book(1, "Pride and Prejudice", .25);
            Book nb2 = new Book(2, "The Hobbit", .25);
            Book nb3 = new Book(3, "Applying UML and Design Patterns", .50);
            availableBooks.Add(nb1);
            availableBooks.Add(nb2);
            availableBooks.Add(nb3);
        }

        public List<Book> listBooks()
        {
            return availableBooks;
        }
        
       
    }
}
