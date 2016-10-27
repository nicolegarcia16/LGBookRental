using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Order
    {
        public int orderNumber;
        public DateTime orderDate;
        public double orderTotal;
        public double subtotal;
        public Book bookRented;
        public string shippingAddress;
        public string creditCardNumber;
        public string displayCreditCardNumber;
        public int rentalLength;

        public Order(string bookName, int bookId, int rentalLength, double pricePerDay)
        {
            bookRented = new Book(bookId, bookName, pricePerDay);
            orderDate = DateTime.Now.Date;
            subtotal = pricePerDay * rentalLength;
            orderTotal = subtotal + subtotal * 0.07; //0.7 is standard GA tax
            this.rentalLength = rentalLength;


        }

        public string toString()
        {
            return "Order Number: " + orderNumber + "\nOrder Date: " + orderDate +
                "\nOrder Total: " + orderTotal + "\nBooks Rented: " + bookRented.bookName;
        }
    }
}
