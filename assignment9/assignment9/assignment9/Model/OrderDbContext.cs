
using Microsoft.EntityFrameworkCore;  

namespace assignment9.Model  //_finish
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
           : base(options) {
            this.Database.EnsureCreated();//自动建库建表
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }    //订单明细表
   
    
    }
}
