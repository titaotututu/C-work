using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order { OrderId = 1, Customer = "wangyao", Details = new List<OrderDetails> { new OrderDetails { ProductName = "dog toy", Price = 25.8, Quantity = 2 } } };
            orderService.AddOrder(order1);

            // Assert
            Assert.AreEqual(1, orderService.orders.Count());   //判断订单数是否等于1
            Assert.IsTrue(orderService.orders.Contains(order1));  //判断订单服务中是否包含了order1
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order { OrderId = 1, Customer = "wangyao", Details = new List<OrderDetails> { new OrderDetails { ProductName = "dog toy", Price = 25.8, Quantity = 2 } } };
            orderService.AddOrder(order1);
            Order order2 = new Order { OrderId = 2, Customer = "linyihang", Details = new List<OrderDetails> { new OrderDetails { ProductName = "mikasa volleyball", Price = 330.9, Quantity = 1 } } };
            orderService.AddOrder(order2);
            orderService.DeleteOrder(1);  //删除一个订单

            Assert.AreEqual(1, orderService.orders.Count());   //判断订单数是否等于1
            Assert.IsTrue(orderService.orders.Contains(order2));  //判断订单服务中是否包含了order2


        }

        [TestMethod()]
        public void UpdateOrderTest()  //订单更新测试
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order { OrderId = 1, Customer = "wangyao", Details = new List<OrderDetails> { new OrderDetails { ProductName = "dog toy", Price = 25.8, Quantity = 2 } } };
            orderService.AddOrder(order1);
            Order order2 = new Order { OrderId = 2, Customer = "linyihang", Details = new List<OrderDetails> { new OrderDetails { ProductName = "mikasa volleyball", Price = 330.9, Quantity = 1 } } };
            orderService.AddOrder(order2);
            Order updateOrder1 = new Order { OrderId = 1, Customer = "wangyao", Details = new List<OrderDetails> { new OrderDetails { ProductName = "shoses", Price = 258, Quantity = 2 } } };
            orderService.UpdateOrder(updateOrder1);  //更新
            Assert.AreEqual(2, orderService.orders.Count());   //判断订单数是否等于2——即更新后数目不变
            Assert.IsTrue(orderService.orders.Contains(order2));  //判断订单服务中是否包含了order2
            Assert.IsTrue(orderService.orders.Contains(updateOrder1));  //判断订单服务中是否包含了order2
        }

        [TestMethod()]
        public void SearchOrdersTest()
        {
            // Arrange
            OrderService orderService = new OrderService();
            Order order1 = new Order { OrderId = 1, Customer = "Alice", Details = new List<OrderDetails> { new OrderDetails { ProductName = "apple", Price = 6, Quantity = 2 } } };
            Order order2 = new Order { OrderId = 2, Customer = "Bob", Details = new List<OrderDetails> { new OrderDetails { ProductName = "banana", Price = 2.5, Quantity = 2 } } };
            Order order3 = new Order { OrderId = 3, Customer = "Alice", Details = new List<OrderDetails> { new OrderDetails { ProductName = "orange", Price = 3, Quantity = 2 } } };
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            // Act
            var filteredAndSortedOrders = orderService.SearchOrders(o => o.Customer == "Alice");

            // Assert
            Assert.AreEqual(2, filteredAndSortedOrders.Count);
            Assert.AreEqual(6, filteredAndSortedOrders[0].TotalAmount);   //按照总金额进行排序后
            Assert.AreEqual(12, filteredAndSortedOrders[1].TotalAmount);
        }

        [TestMethod()]
        public void SortOrdersTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order { OrderId = 1, Customer = "Tom", Details = new List<OrderDetails> { new OrderDetails { ProductName = "apple", Price = 10, Quantity = 2 } } };
            Order order2 = new Order { OrderId = 2, Customer = "Bob", Details = new List<OrderDetails> { new OrderDetails { ProductName = "banana", Price = 30, Quantity = 2 } } };
            Order order3 = new Order { OrderId = 3, Customer = "Alice", Details = new List<OrderDetails> { new OrderDetails { ProductName = "orange", Price = 20, Quantity = 2 } } };
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            orderService.SortOrders((o1, o2) => o2.TotalAmount.CompareTo(o1.TotalAmount)); // 按照总价进行排序
            Assert.AreEqual(60, orderService.orders[0].TotalAmount);
            Assert.AreEqual(40, orderService.orders[1].TotalAmount);
            Assert.AreEqual(20, orderService.orders[2].TotalAmount);

        }
    }
}