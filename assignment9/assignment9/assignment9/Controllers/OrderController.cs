using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using assignment9.Model;

namespace assignment9.Contrllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;  //对订单的操作

        //构造函数把OrderContext作为参数 Asp.net core 框架额可以自动注入OrderContext对象

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService; 
        }


        // GET: api/Order
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()  //获取所有订单
        {
            return orderService.GetAllOrders();
        }


        //GET:api/order/{id} ——路径参数
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(long id)  //获取订单
        {
            var order = orderService.GetOrder(id);
            return (order == null) ? NotFound() : order;

        }


        //Post:api/Order   请求添加新订单
        [HttpPost]
        public ActionResult<Order> AddOrder(Order order)
        {
            try
            {
                order.OrderId = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);   //将这个数组转换成long类型
                orderService.AddOrder(order);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);  //发送消息异常信息
            }

            return order;
        }



        //PUT:api/Order/{id}   请求更新订单
        [HttpPut("{id}")]
        public ActionResult<Order> udpateOrder(long id, Order order)
        {
            if (id != order.OrderId)  //检查请求更新的订单号跟订单的是否一致
            {
                return BadRequest();
            }
            try   //一致时执行以下操作
            {
                orderService.UpdateOrder(order);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }


        //删除 DELETE：api/Order/{id}
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(long id)
        {
            try
            {
                orderService.RemoveOrder(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }





    }




}