using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGBookRental
{
    public class Book
    {
        public int bookId;
        public string bookName;
        public double rentalPrice;

        public Book(int id, string name, double price)
        {
            bookId = id;
            bookName = name;
            rentalPrice = price;
        }
    }
}
