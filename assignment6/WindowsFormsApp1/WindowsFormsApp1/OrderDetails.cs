using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class OrderDetails  //订单明细类——finish
    {
        public string ProductName { get; set; }  //商品名称
        public double Price { get; set; } //商品价格
        public int Quantity { get; set; } //购买的商品数量
     //   public double TotalPrice => Price * Quantity;   //订单总价
        public override string ToString()  //重写方法
        {
            return $"Product Name: \t{ProductName}\nProduct Price: \tCNY￥{Price}\nProduct Amount: {Quantity}";
        }

        public override int GetHashCode()  //用于后面判断订单是否相同
        {
            var hashCode = 810000000;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductName);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
        public override bool Equals(object obj)  //订单明细不重复
        {
            var item = obj as OrderDetails;
            return item != null &&
                   ProductName == item.ProductName &&
                   Price == item.Price &&
                   Quantity == item.Quantity;
        }
    }
}
