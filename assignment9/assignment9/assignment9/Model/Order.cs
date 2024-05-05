using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


namespace assignment9.Model  //——finish
{
    public class Order:IComparable<Order>  //订单类
    {
        public long OrderId { get; set; }  //订单号
        [Required]  //字段属性不能为空
        public DateTime OrderTime { get; set; }  //订单日期
        public string CustomerName { get; set; }  //顾客姓名

        public string Address { get; set; } //地址
        public double TotalAmount { get; set; }  //订单总价
        public List<OrderDetails> Details { get; set; }  //存放订单明细

        public Order()
        {   //初始化一个订单
            OrderTime = DateTime.Now;  //订单时间等于当前时间
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);  //标识这段时间的总秒数
            OrderId = Convert.ToInt64(ts.TotalSeconds);     //使用时间戳作为订单号
            Details = new List<OrderDetails>();
            TotalAmount = 0;  //初始总价设为0
        }

        //添加订单明细
        public void AddOrderDetails(OrderDetails orderdetails)
        {
            foreach (OrderDetails item in Details)
            {
                if (item.Equals(orderdetails))   //当订单号相同的时候进行提示
                {
                    throw new ApplicationException("Error: Adding a repeat order item is not allowed");
                }
            }

            Details.Add(orderdetails);
            TotalAmount += orderdetails.Price * orderdetails.Quantity;   //重新更新总价 
     
        }


        //删除订单明细
        public void RemoveOrderDetails(OrderDetails orderdetails)
        {
            if (!Details.Remove(orderdetails))  //删除订单的时候进行合理性的判断
            {
                throw new ApplicationException("Error: No such order item");
            }
            Details.Remove(orderdetails);
            TotalAmount -= orderdetails.Price * orderdetails.Quantity;
        }
       
        
        //高速构建字符串
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("---------------------------------------------------\n");
            stringBuilder.Append($"Order ID: \t{OrderId}\n");
            stringBuilder.Append($"Order Time: \t{OrderTime.ToString("yyyy-MM-dd HH:mm:ss")}\n");
            stringBuilder.Append($"Customer Name: \t{CustomerName}\n");
            stringBuilder.Append($"Address: \t{Address}\n");
            stringBuilder.Append("---------------------------------------------------\n");
            stringBuilder.Append("Order Details\n");
            foreach (OrderDetails item in Details)
            {
                stringBuilder.Append("--------------------------\n");
                stringBuilder.Append($"{item}\n");
            }
            stringBuilder.Append("--------------------------\n");
            stringBuilder.Append($"Total Price: \tCNY￥{TotalAmount}\n");
            stringBuilder.Append("---------------------------------------------------");
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)  //判断两个订单是否相等
        {
            var order = obj as Order;
            return order != null &&
                   OrderId == order.OrderId &&
                   OrderTime == order.OrderTime &&
                   CustomerName == order.CustomerName &&
                   Address == order.Address &&
                   TotalAmount == order.TotalAmount &&
                   EqualityComparer<List<OrderDetails>>.Default.Equals(Details, order.Details);
        }

        public override int GetHashCode()
        {
            var hashCode = -765576449;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderTime.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + TotalAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(Details);
            return hashCode;
        }

        //两个对象的顺序比较（通过id号）
        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderId.CompareTo(other.OrderId);
        }

    }


}


