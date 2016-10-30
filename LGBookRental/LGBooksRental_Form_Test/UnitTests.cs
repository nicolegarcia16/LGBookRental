using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LGBookRentals;
using System.Collections.Generic;

namespace LGBooksRental_Form_Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestAddAvailableBooks()
        {
            User currentUser = new User("nicole", "word");
            availableBooksPage bookApp = new availableBooksPage(currentUser);
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
        public void TestCreateOrderMethod()
        {
            User currentUser = new User("nicole", "word");
            availableBooksPage bookApp = new availableBooksPage(currentUser);
            Book selectedBook = new Book(12, "Patterns", 12.99);
            Order order1 =  bookApp.createNewOrder(selectedBook, 3);
            double intendedPrice = 12.99 * 3 + 12.99 * 3 * 0.07;
            Assert.AreEqual(order1.orderTotal, intendedPrice);
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
        public void TestAddOrderToAccountMethod()
        {
            User currentUser = new User("nicole", "word");
            availableBooksPage bookApp = new availableBooksPage(currentUser);
            Book selectedBook = new Book(12, "Patterns", 12.99);
            Order order1 = bookApp.createNewOrder(selectedBook, 3);
            bookApp.addOrderToAccount(order1, currentUser);
            Assert.IsTrue(currentUser.orders.Count > 0);
        }

        [TestMethod]
        public void TestAddShippingAndPaymentInfo()
        {
            User currentUser = new User("nicole", "word");
            Order testOrder = new Order("Test", 12, 3, 5.00);
            checkoutPage currentCheckoutPage = new checkoutPage(testOrder, currentUser);
            testOrder = currentCheckoutPage.addShippingAndPaymentInfo(testOrder,
                "982 Magnolia St.", "1234567890");
            Assert.AreEqual(testOrder.shippingAddress, "982 Magnolia St.");
        }

        [TestMethod]
        public void TestCreateDisplayCreditCardNumber()
        {
            User currentUser = new User("nicole", "word");
            Order testOrder = new Order("Test", 12, 3, 5.00);
            checkoutPage currentCheckoutPage = new checkoutPage(testOrder, currentUser);
            testOrder = currentCheckoutPage.addShippingAndPaymentInfo(testOrder, "982 Magnolia St.", "1234567890");
            string displayNumber = currentCheckoutPage.createDisplayCreditCardNumber(testOrder.creditCardNumber);
            Assert.AreEqual(displayNumber, "******7890");
        }

        [TestMethod]
        public void TestAddDisplayCreditCardNumberToOrder()
        {
            User currentUser = new User("nicole", "word");
            Order testOrder = new Order("Test", 12, 3, 5.00);
            checkoutPage currentCheckoutPage = new checkoutPage(testOrder, currentUser);
            testOrder = currentCheckoutPage.addShippingAndPaymentInfo(testOrder, "982 Magnolia St.", "1234567890");
            string displayNumber = currentCheckoutPage.createDisplayCreditCardNumber(testOrder.creditCardNumber);
            currentCheckoutPage.addDisplayCreditCardNumberToOrder(testOrder, displayNumber);
            Assert.AreEqual(testOrder.displayCreditCardNumber, "******7890");
        }


        [TestMethod]
        public void TestCreateAndAddDisplayCreditCardNumber()
        {
            User currentUser = new User("nicole", "word");
            Order testOrder = new Order("Test", 12, 3, 5.00);
            checkoutPage currentCheckoutPage = new checkoutPage(testOrder, currentUser);
            testOrder = currentCheckoutPage.addShippingAndPaymentInfo(testOrder, "982 Magnolia St.", "1234567890");
            currentCheckoutPage.createAndAddDisplayCreditCardNumber(testOrder);
            Assert.AreEqual(testOrder.displayCreditCardNumber, "******7890");
        }
    }
}
