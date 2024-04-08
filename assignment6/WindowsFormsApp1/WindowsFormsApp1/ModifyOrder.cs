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
    public partial class ModifyOrder : Form

    {   public Order NewOrder { get; set; }  //新的订单
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public ModifyOrder(Order order)
        {
            InitializeComponent();
            NewOrder= order;
        }
        private void ModifyOrder_Load(object sender, EventArgs e)
        {
            textCustomerName.DataBindings.Add("Text", this, "CustomerName");
            textAddress.DataBindings.Add("Text", this, "Address");
            CustomerName = NewOrder.CustomerName;
            Address = NewOrder.Address;
            NewOrder.TotalAmount = 0;
            itemBindingSource.DataSource = NewOrder.Details;

        }
        //数据格式错误时
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("无效的数据格式！", "ERROR");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //确认按键
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CustomerName == "")
            {
                MessageBox.Show("客户名不能为空！");
                return;
            }

            if (Address == "")
            {
                MessageBox.Show("配送地址不能为空！");
                return;
            }

            if (NewOrder.Details == null || NewOrder.Details.Count == 0)
            {
                MessageBox.Show("订单详情不能为空！");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
