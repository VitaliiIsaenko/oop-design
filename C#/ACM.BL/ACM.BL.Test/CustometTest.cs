using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustometTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            string expected = "Baggins, Bilbo";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            string expected = "Baggins";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            string expected = "Bilbo";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            var c2 = new Customer();
            c1.FirstName = "Frodo";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c1.FirstName = "Aragorn";
            Customer.InstanceCount++;

            Assert.AreEqual(Customer.InstanceCount, 3);
        }
    }
}
