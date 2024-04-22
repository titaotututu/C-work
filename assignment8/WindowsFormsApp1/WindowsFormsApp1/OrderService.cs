using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
   public class OrderService   //订单服务类_finish
    {

        public List<Order> orders { get; set; }  //存放所有的订单
        public OrderService()
        {
            //orders = new List<Order>();  //自动初始化orders
            ImportFromDB();
        }

        public void AddOrder(Order order) //添加订单
        {
            if (orders.Contains(order))  //检查是否包含该对象
                throw new InvalidOperationException("Order already exists.");
            orders.Add(order);
            using (var context =new OrderContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }
        //添加订单明细
        public void AddOrderDetails(Order order,OrderDetails orderDetails)
        {
            try
            {
                order.AddOrderDetails(orderDetails);
                long checkId = order.OrderId;
                using (var context = new OrderContext())
                {
                    var checkOrder = context.Orders.FirstOrDefault(p => p.OrderId == checkId);
                    //错误的写法
                    checkOrder.AddOrderDetails(orderDetails);
                    context.SaveChanges();
                }
            }
            catch (ApplicationException e)
            {
                throw e;
            }
        }

        //——————查询————————————————————————————

        //根据订单号查询订单
        public Order QueryByOrderID(long orderID)
        {
            //var query = from s in OrderList
            //            where s.OrderID == orderID
            //            select s;
            //var query = orders.Where(x => x.OrderId == orderID).OrderBy(s => s.TotalAmount);

            //return query.FirstOrDefault();
            using (var context = new OrderContext())
            {
                var query = context.Orders.Include("Details").FirstOrDefault(x => x.OrderId == orderID);
                return query;
            }
        }
        //根据商品名称进行查询
        public List<Order> QueryByProductName(string queryContent)
        {
            //var query = orders.Where(x => x.Details.Exists(y => y.ProductName.Contains(queryContent))).OrderBy(s => s.TotalAmount);  //查找，用总金额及进行排序

            //return query.ToList();

            using (var context = new OrderContext())
            {
                var query = context.Orders.Include("Details").Where(x => x.Details.Any(y => y.ProductName.Contains(queryContent))).OrderBy(s => s.TotalAmount);
                return query.ToList();
            }
        }


        //根据客户进行查询
        public List<Order> QueryByCustomerName(string queryContent)
        {

            //var query = orders.Where(x => x.CustomerName.Contains(queryContent)).OrderBy(s => s.TotalAmount);

            //return query.ToList();

            using (var context = new OrderContext())
            {
                var query = context.Orders.Include("Details").Where(x => x.CustomerName.Contains(queryContent)).OrderBy(s => s.TotalAmount);
                return query.ToList();
            }

        }
        //默认排序：订单号
        public void SortOrderList()
        {
            orders.Sort((x, y) => (int)(x.OrderId - y.OrderId));   //进行升序排序
        }
        //使用Lambda表达式进行自定义排序
        //例如: SortOrderList((x,y)=> (int)(x.TotalPrice - y.TotalPrice));
        public void SortOrderList(Func<Order, Order, int> sortAction)
        {
            orders.Sort((x, y) => sortAction(x, y));
        }

        public void RemoveOrder(long orderId)  //删除订单——通过订单号进行指定
        {
            Order order = QueryByOrderID(orderId);
            if (order == null)   //没找到指定订单号的时候抛出异常
            { throw new KeyNotFoundException("No found Order."); }
            else { orders.Remove(order); }
        }

        //根据订单进行删除
        public void RemoveOrder(Order order)
        {
            orders.Remove(order);
            long checkId = order.OrderId;
            using (var context = new OrderContext())
            {
                var checkOrder = context.Orders.Include("Details").FirstOrDefault(p => p.OrderId == checkId);
                if (checkOrder != null)
                {
                    context.Orders.Remove(checkOrder);
                    context.SaveChanges();
                }
            }

        }

        //删除订单明细
        public void RemoveOrderItem(Order order, OrderDetails orderdetail)
        {
            try
            {
                order.RemoveOrderDetails(orderdetail);
                long checkId=order.OrderId;
                using (var context = new OrderContext())
                {
                    var checkOrder = context.Orders.FirstOrDefault(p => p.OrderId == checkId);
                    if (checkOrder != null)
                    {
                        //错误的写法
                        checkOrder.RemoveOrderDetails(orderdetail);
                        context.SaveChanges();
                    }
                }
            }
            catch (ApplicationException e)
            {
                throw e;
            }
        }

        /*
       //根据订单号和类型修改订单
        //type-1 Modify Customer Name
        //type-2 Modify Address
        //modifiedContent 已修改的内容   
         */
        public void ModifyOrder(long orderID, int type, string modifiedContent)
        {
            //处理没有查询到订单的异常
            Order order = QueryByOrderID(orderID);

            if (order == null)
            {
                throw new ApplicationException("Error: No such order");
            }

            switch (type)
            {
                case 1:  //修改客户的姓名
                    order.CustomerName = modifiedContent;
                    break;
                case 2: //修改地址
                    order.Address = modifiedContent;
                    break;
            }
        }

        //根据订单对象和类型修改订单
        //type-1 Modify Customer Name
        //type-2 Modify Address
        //modifiedContent 已修改的内容
        public void ModifyOrder(Order order, int type, string modifiedContent)
        {
            switch (type)
            {
                case 1:
                    order.CustomerName = modifiedContent;
                    break;
                case 2:
                    order.Address = modifiedContent;
                    break;
            }
        }

        //根据订单修改订单
        public void ModifyOrder(Order order, Order newOrder)
        {
            long checkId = order.OrderId;
            order = newOrder;
            using (var context = new OrderContext())
            {
                var checkOrder = context.Orders.Include("Details").FirstOrDefault(p => p.OrderId == checkId);
                if (checkOrder != null)
                {
                    checkOrder.CustomerName = newOrder.CustomerName;
                    checkOrder.Address = newOrder.Address;
                    checkOrder.TotalAmount = newOrder.TotalAmount;

                    List<int> IdsToBeDelete = new List<int>();
                    foreach (OrderDetails item in checkOrder.Details)
                    {
                        IdsToBeDelete.Add(item.OrderItemId);
                    }

                    foreach (int i in IdsToBeDelete)
                    {
                        var item = context.OrderDetails.FirstOrDefault(p => p.OrderItemId == i);
                        context.OrderDetails.Remove(item);
                    }

                    foreach (OrderDetails item in newOrder.Details)
                    {
                        OrderDetails newItem = new OrderDetails();
                        newItem.Quantity = item.Quantity;
                        newItem.ProductName = item.ProductName;
                        newItem.Price = item.Price;
                        newItem.OrderId = checkId;
                        checkOrder.Details.Add(newItem);
                    }
                    context.SaveChanges();
                }
            }

        }


        public void UpdateOrder(Order updateOrder)  //更新订单的信息——删除原有订单信息之后再重新添加订单
        {
            Order order = orders.FirstOrDefault(o => o.OrderId == updateOrder.OrderId);
            if (order == null)
                throw new KeyNotFoundException("Cannot find Order!");
            orders.Remove(order);
            orders.Add(updateOrder);
        }

        //根据指定条件对订单进行查询
        public List<Order> SearchOrders(Func<Order, bool> condition)
        {
            return orders.Where(condition).OrderBy(x => x.TotalAmount).ToList();   //最后将结果转化为一个list
        }

        //对订单进行排序
        public void SortOrders(Comparison<Order> comparison = null)
        {
            if (comparison == null)
                orders.Sort();
            else
                orders.Sort(comparison);
        }

        //从数据库中载入订单
        public void ImportFromDB()
        {
            using(var context =new OrderContext())
            {
                orders =context.Orders.Include("Details").ToList();  //包含关联的表的数据
            }
        }




    }
}
