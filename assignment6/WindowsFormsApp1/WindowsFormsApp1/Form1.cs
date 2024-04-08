using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public OrderService OS;
        public long QueryOrderID { get; set; }  //订单的id
        public string QueryProductName { get; set; }
        public string QueryCustomerName { get; set; }

       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            searchType.SelectedIndex = 0;
            OS = new OrderService();
            orderBindingSource.DataSource = OS.orders;
            QueryOrderID = 0;
            QueryProductName = "";
            QueryCustomerName = "";
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)  //添加订单按键
        {
            AddOrder addOrder = new AddOrder();  //新建添加订单的窗口
            if (addOrder.ShowDialog() == DialogResult.OK)
            {
                OS.AddOrder(addOrder.NewOrder);
                orderBindingSource.DataSource = OS.orders;
                orderBindingSource.ResetBindings(false);
            }
        }
        private void btn_DeleteOrder_Click(object sender, EventArgs e)  //删除订单按键_根据订单进行删除
        {
            OS.RemoveOrder(orderBindingSource.Current as Order);   //将当前选中的项目转为Order对象
            orderBindingSource.ResetBindings(false);  //重置数据源中的绑定
        }

        //修改订单按键
        private void btn_ModifyOrder_Click(object sender, EventArgs e)
        {
            ModifyOrder modifyOrder = new ModifyOrder(orderBindingSource.Current as Order);
            if (modifyOrder.ShowDialog() == DialogResult.OK)
            {
                OS.ModifyOrder(orderBindingSource.Current as Order, modifyOrder.NewOrder);
                orderBindingSource.DataSource = OS.orders;
                orderBindingSource.ResetBindings(false);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 导出带你孤单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 管理系统的信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderIn_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //选择订单查询方式
        private void searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchType.SelectedIndex)
            {
                case 0:
                    textBox1.DataBindings.Clear();
                    textBox1.DataBindings.Add("Text", this, "QueryOrderID");  //订单号查询
                    break;
                case 1:
                    textBox1.DataBindings.Clear(); 
                    textBox1.DataBindings.Add("Text", this, "QueryProductName");  //商品名查询
                    break;
                case 2:
                    textBox1.DataBindings.Clear();
                    textBox1.DataBindings.Add("Text", this, "QueryCustomerName");  //顾客名查询
                    break;
                default:
                    break;
            }

        }

        //查询订单按键——调用orderservice中的查询方式
        private void btnQueryOrder_Click(object sender, EventArgs e)
        {
            List<Order> newList;
            switch (searchType.SelectedIndex)
            {
                case 0:
                    Order order = OS.QueryByOrderID(QueryOrderID);
                    newList = new List<Order>();
                    newList.Add(order);
                    orderBindingSource.DataSource = newList;
                    orderBindingSource.ResetBindings(false);
                    break;
                case 1:
                    newList = OS.QueryByProductName(QueryProductName);
                    orderBindingSource.DataSource = newList;
                    orderBindingSource.ResetBindings(false);
                    break;
                case 2:
                    newList = OS.QueryByCustomerName(QueryCustomerName);
                    orderBindingSource.DataSource = newList;
                    orderBindingSource.ResetBindings(false);
                    break;
                default:
                    break;
            }
        }
        //显示所有订单按键
        private void ShowAll_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = OS.orders;
            orderBindingSource.ResetBindings(false);
        }





    }
}
