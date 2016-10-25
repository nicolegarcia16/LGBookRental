using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGBookRental;

namespace LGBookRental
{
    class Program
    {
        static void Main(string[] args)
        {
            //login frm = new login();
            //frm.Show();

            int bookId = 0;
            int numDays = 0;
            Inventory myInventory = new Inventory();
            myInventory.addBooks();
            List<Book> books = myInventory.listBooks();
            foreach( Book book in books)
            {
                Console.WriteLine("Id: " + book.bookId + " Name: " + book.bookName);
              
            }
            Console.WriteLine("Which book ID would you like to check out?");
            bookId = int.Parse(Console.ReadLine());
            

            Book myBook = books.Find(x => x.bookId.Equals(bookId));
            Order myOrder = new LGBookRental.Order();
            myOrder.booksRented.Add(myBook);
            myOrder.orderDate = DateTime.Today;

            
            Console.WriteLine("How many days do you want to check it out for?");
            numDays = int.Parse(Console.ReadLine());

            double subTotal = myBook.rentalPrice * numDays;
            double tax = subTotal * .07;
            myOrder.orderTotal = subTotal + tax;
            myOrder.orderNumber = 1;
            Console.Write(myOrder.toString());
            Console.ReadLine();
            
        }
        public void DoStuff()
{
    Console.WriteLine("I'm doing something...");
}
    }
}
