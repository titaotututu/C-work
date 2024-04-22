using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1   //添加订单窗口
{
    public partial class AddOrder : Form
    {
        public Order NewOrder { get; set; }   //创建新的订单对象

        public string CustomerName { get; set; } //客户名
        public string Address {  get; set; }   //地址

        public AddOrder()  //初始化控件
        {
            InitializeComponent();
        }

        //当表单加载时，初始化新的订单对象，并将两个客户名和地址置为空值
        //接着，绑定数据源
        private void AddOrder_Load(object sender,EventArgs e)
        {
            NewOrder= new Order();  //新建一个订单对象
            CustomerName = "";
            Address = "";
            CustomerNametxt.DataBindings.Add("Text", this, "CustomerName");
            Addresstxt.DataBindings.Add("Text", this, "Address");
            itemBindingSource.DataSource = NewOrder.Details;   //需要一个数据源
        }

        //事件处理
        private void dgvOrderItem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("无效的数据格式！", "ERROR");

        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        //确定按键
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CustomerName == ""){
                MessageBox.Show("客户名不能为空！");
                return;
            }
            if (Address == "")
            {
                MessageBox.Show("地址不能为空！");
                return;
            }
            NewOrder.CustomerName = CustomerName;
            NewOrder.Address = Address;

            foreach (OrderDetails item in NewOrder.Details)
            {
                NewOrder.TotalAmount += item.Price * item.Quantity;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();



        }

        //撤销按键
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {

        }
    }
}
