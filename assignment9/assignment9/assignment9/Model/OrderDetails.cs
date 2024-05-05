using System.ComponentModel.DataAnnotations;

namespace assignment9.Model
{
    public class OrderDetails   //订单明细类_finish
    {

        [Key]
        public int OrderItemId { get; set; }  //商品的id号，主要是用于做主键
        public string ProductName { get; set; }  //商品名称
        [Required]
        public double Price { get; set; } //商品价格
        public int Quantity { get; set; } //购买的商品数量
          //   public double TotalPrice => Price * Quantity;   //订单总价
        public long OrderId { get; set; }  //订单号——自动识别为外键
        public Order Order { get; set; }  //多对一关联

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
                   OrderItemId == item.OrderItemId &&
                   ProductName == item.ProductName &&
                   Price == item.Price &&
                   Quantity == item.Quantity &&
                   OrderId == item.OrderId &&
                   EqualityComparer<Order>.Default.Equals(Order, item.Order);
        }
    }
}
