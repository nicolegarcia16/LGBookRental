using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WindowsFormsApplication1
{
    [TestClass]
    class UnitTests
    {
        [TestMethod]
        void TestAddBooks()
        {
            app bookApp = new WindowsFormsApplication1.app();
            List<Book> bookList = bookApp.addAvailableBooks();
            Assert.IsTrue(bookList.Count() > 0);
        }

        [TestMethod]
        void TestCreateOrder()
        {
            
        }

        [TestMethod]
        void TestPlaceOrder()
        {

        }

    }
}
