using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;
using System.Runtime.InteropServices;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_ShouldStoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            var orderService = new OrderService(storage.Object);

            var  order = new Order();

            orderService.PlaceOrder(order);

            storage.Verify(s => s.Store(order));

        }
    }
}
