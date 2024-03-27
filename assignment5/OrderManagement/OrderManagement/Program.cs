/*写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。
* 并对各个Public方法编写测试用例。
* 提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。要求：（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。  okk（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。   okk（5） OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

//订单明细类
public class OrderDetails : IEquatable<OrderDetails>
{
    public string ProductName { get; set; }  //商品名称
    public double Price { get; set; } //商品价格
    public int Quantity { get; set; } //购买的商品数量
    public double TotalPrice => Price * Quantity;   //订单总价
    public override string ToString()  //重写方法
    {
        return $"ProductName:{ProductName},Price:{Price},Quantity:{Quantity},TotalPrice:{TotalPrice} ";
    }

    public bool Equals(OrderDetails other)  //订单明细不重复
    {
        if (other == null) return false;
        return ProductName == other.ProductName && Price == other.Price && Quantity == other.Quantity;
    }

}

//订单类Order
public class Order : IEquatable<Order>, IComparable<Order>
{
    public int OrderId { get; set; }
    public string Customer { get; set; }
    public List<OrderDetails> Details { get; set; }  //存放订单明细

    public double TotalAmount => Details.Sum(detail => detail.TotalPrice);  //detail参数在lambda表达式中被定义，且返回的是list中每个成员的值

    public override string ToString()
    {
        return $"Order id:{OrderId},Customer name :{Customer},Total amount:{TotalAmount}";
    }

    public bool Equals(Order other)
    {
        if (other == null) return false;
        return OrderId == other.OrderId;  //订单号唯一标识订单
    }

    public int CompareTo(Order other)
    {
        if (other == null) return 1;
        return TotalAmount.CompareTo(other.TotalAmount);
    }
}

//订单服务类
public class OrderService
{
    public List<Order> orders;  //存放所有的订单
    public OrderService()
    {
        orders = new List<Order>();
    }

    public void AddOrder(Order order) //添加订单
    {
        if (orders.Contains(order))  //检查是否包含该对象
            throw new InvalidOperationException("Order already exists.");
        orders.Add(order);
    }

    public void DeleteOrder(int orderId)  //删除订单——通过订单号进行指定
    {
        Order order = orders.FirstOrDefault(o => o.OrderId == orderId);
        if (order == null)   //没找到指定订单号的时候抛出异常
            throw new KeyNotFoundException("No found Order.");
        orders.Remove(order);
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
}

class Program
{
    public static void Main(string[] args)
    {
        OrderService orderService = new OrderService();
        //添加订单测试用例
        Order order1 = new Order { OrderId = 1, Customer = "wangyao", Details = new List<OrderDetails> { new OrderDetails { ProductName = "dog toy", Price = 25.8, Quantity = 2 } } };
        orderService.AddOrder(order1);

        Order order2 = new Order { OrderId = 2, Customer = "linyihang", Details = new List<OrderDetails> { new OrderDetails { ProductName = "mikasa volleyball", Price = 330.9, Quantity = 1 } } };
        orderService.AddOrder(order2);

        //删除订单_测试：删除不存在的订单
        try
        {
            orderService.DeleteOrder(3);  //
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:{ex.Message}");
        }

        //更新订单
        Order updateOrder1 = new Order { OrderId = 1, Customer = "wangyao", Details = new List<OrderDetails> { new OrderDetails { ProductName = "shoses", Price = 258, Quantity = 2 } } };
        try
        {
            orderService.UpdateOrder(updateOrder1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:{ex.Message}");
        }

        //查询订单的测试用例
        List<Order> searchOrder = orderService.SearchOrders(x => x.Customer == "wangyao");
        foreach (var order in searchOrder)
        {
            Console.WriteLine(order);
        }
    }

}