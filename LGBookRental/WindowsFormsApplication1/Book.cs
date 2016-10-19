using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Book
    {
        public int bookId { get; set; } 
        public string bookName { get; set; }
        public double rentalPrice { get; set; }

        public Book(int id, string name, double price)
        {
            bookId = id;
            bookName = name;
            rentalPrice = price;
        }



    }
}
