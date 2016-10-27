using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGBookRentals
{
    public class bookViewLogic
    {
        public List<Book> addAvailableBooks()
        {
            List<Book> availableBooks = new List<Book>();
            availableBooks.Add(new Book(547628, "UML Patterns", 47.99));
            availableBooks.Add(new Book(2, "Test Patterns", 12.99));
            return availableBooks;
        }

    }
}
