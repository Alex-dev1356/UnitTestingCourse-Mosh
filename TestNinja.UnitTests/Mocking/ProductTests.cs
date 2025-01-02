using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class ProductTests
    {
        //[Test]
        //public void GetPrice_GoldCustomer_Apply30Discount()
        //{
        //    var product = new Product() { ListPrice = 100 };

        //    var result = product.GetPrice(new Customer() { IsGold = true });

        //    Assert.That(result, Is.EqualTo(70));
        //}

        //Example of Mock Abuse, we need to extract an interface from Customer Class then 
        //refactor the Argument of GetPriceMethod on then we create a Mock here. 
        [Test]
        public void GetPrice_GoldCustomer_Apply30Discount()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(c => c.IsGold).Returns(true);

            var product = new Product() {ListPrice = 100};
            var result = product.GetPrice(customer.Object);

            Assert.That(result, Is.EqualTo(70));
        }
        //With this implementation, we could see that the first test is far more simpler than doing a Mock.
        //The second test is harder to read and understand.
    }
}
