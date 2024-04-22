using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OrderContext:DbContext
    {
        public OrderContext() : base("OrderDataBase")   //连接字符串——指定了数据库的名称
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        //在数据库中创建两个表
        public DbSet<Order> Orders { get; set; }  //Order表
        public DbSet<OrderDetails> OrderDetails {  get; set; }    //订单明细表
    }
}
