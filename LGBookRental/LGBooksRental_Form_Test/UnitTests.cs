using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System.Collections.Generic;

namespace LGBooksRental_Form_Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestAddAvailableBooks()
        {
            availableBooksPage bookApp = new availableBooksPage();
            List<Book> bookList = bookApp.addAvailableBooks();
            Assert.IsTrue(bookList.Count > 0);
        }

        [TestMethod]
        public void TestCreateOrder()
        {
            Order order1 = new Order("name", 12, 3, 3.00);
            order1.shippingAddress = "982 Magnolia St., Macon, GA 31201";
            order1.creditCardNumber = "1234567890";
            Assert.AreEqual(order1.subtotal, 9.00);
            Assert.AreEqual("982 Magnolia St., Macon, GA 31201", order1.shippingAddress);
        }

        [TestMethod]
        public void TestAddOrderToAccount()
        {
            User user1 = new User("nicole", "word");
            Order order1 = new Order("Test Patterns", 2, 3, 12.99);
            user1.orders.Add(order1);
            Assert.IsTrue(user1.orders.Count > 0);
        }

        [TestMethod]
        public void TestPlaceOrder()
        {
            User user1 = new User("nicole", "word");
            Order order1 = new Order("Test Patterns", 2, 3, 12.99);
            user1.orders.Add(order1);
            Assert.IsTrue(user1.orders.Count > 0);
        }
    }
}
