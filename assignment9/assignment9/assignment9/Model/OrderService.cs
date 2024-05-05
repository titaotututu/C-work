using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Mysqlx.Crud;


namespace assignment9.Model   //——finish
{
    public class OrderService   //对订单进行管理
    {
        OrderDbContext dbContext;
        public OrderService(OrderDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //获取所有订单对象
        public List<Order> GetAllOrders()
        {
            return dbContext.Orders
                .Include(o => o.Details).ThenInclude(d => d.ProductName)
                .Include(o => o.CustomerName)
                .ToList<Order>();
        }

        //获取订单
        public Order GetOrder(long id)
        {  //获取订单
            return dbContext.Orders
                .Include(o => o.Details).ThenInclude(d => d.ProductName)
                .Include(o => o.CustomerName)
                .SingleOrDefault(o => o.OrderId == id);
        }


        //添加订单
        public void AddOrder(Order order)
        {
            dbContext.Entry(order).State = EntityState.Added;  //该实体应该被添加到数据库中
            dbContext.SaveChanges();//保存更改
        }

        //删除订单
        //根据订单号进行删除
        public void RemoveOrder(long orderId)
        {
            var order = dbContext.Orders
               .Include(o => o.Details)
               .SingleOrDefault(o => o.OrderId == orderId);
            if (order == null) return;
            dbContext.OrderDetails.RemoveRange(order.Details);
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();

        }

        //------------------查询---------------
        //根据订单号查询订单
        public Order QueryByOrderID(long orderID)
        {
                var query = dbContext.Orders.Include("Details").FirstOrDefault(x => x.OrderId == orderID);
                return query;
        }
        //根据商品名称进行查询
        public List<Order> QueryByProductName(string queryContent)
        {
            var query = dbContext.Orders.Include("Details").Where(x => x.Details.Any(y => y.ProductName.Contains(queryContent))).OrderBy(s => s.TotalAmount);
            return query.ToList();
        }


        //根据客户进行查询
        public List<Order> QueryByCustomerName(string queryContent)
        {
                var query = dbContext.Orders.Include("Details").Where(x => x.CustomerName.Contains(queryContent)).OrderBy(s => s.TotalAmount);
                return query.ToList();

        }


        //更新订单
        public void UpdateOrder(Order newOrder)
        {  //更新订单
            RemoveOrder(newOrder.OrderId);
            AddOrder(newOrder);
        }

    }
}
