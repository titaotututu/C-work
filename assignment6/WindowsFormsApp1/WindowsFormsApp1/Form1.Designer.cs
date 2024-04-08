namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.itemBindingSourse = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.btn_DeleteOrder = new System.Windows.Forms.Button();
            this.btn_ModifyOrder = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnQueryOrder = new System.Windows.Forms.Button();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.OrderList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinglePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSourse.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemBindingSourse
            // 
            this.itemBindingSourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemBindingSourse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.itemBindingSourse.Controls.Add(this.btn_AddOrder);
            this.itemBindingSourse.Controls.Add(this.btn_DeleteOrder);
            this.itemBindingSourse.Controls.Add(this.btn_ModifyOrder);
            this.itemBindingSourse.Controls.Add(this.ShowAll);
            this.itemBindingSourse.Location = new System.Drawing.Point(0, 37);
            this.itemBindingSourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemBindingSourse.Name = "itemBindingSourse";
            this.itemBindingSourse.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.itemBindingSourse.Size = new System.Drawing.Size(1607, 70);
            this.itemBindingSourse.TabIndex = 0;
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_AddOrder.Location = new System.Drawing.Point(3, 15);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(122, 36);
            this.btn_AddOrder.TabIndex = 0;
            this.btn_AddOrder.Text = "添加订单\r\n";
            this.btn_AddOrder.UseVisualStyleBackColor = false;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // btn_DeleteOrder
            // 
            this.btn_DeleteOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_DeleteOrder.Location = new System.Drawing.Point(136, 15);
            this.btn_DeleteOrder.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_DeleteOrder.Name = "btn_DeleteOrder";
            this.btn_DeleteOrder.Size = new System.Drawing.Size(122, 36);
            this.btn_DeleteOrder.TabIndex = 1;
            this.btn_DeleteOrder.Text = "删除订单\r\n";
            this.btn_DeleteOrder.UseVisualStyleBackColor = false;
            this.btn_DeleteOrder.Click += new System.EventHandler(this.btn_DeleteOrder_Click);
            // 
            // btn_ModifyOrder
            // 
            this.btn_ModifyOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ModifyOrder.Location = new System.Drawing.Point(269, 15);
            this.btn_ModifyOrder.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_ModifyOrder.Name = "btn_ModifyOrder";
            this.btn_ModifyOrder.Size = new System.Drawing.Size(122, 36);
            this.btn_ModifyOrder.TabIndex = 0;
            this.btn_ModifyOrder.Text = "修改订单\r\n";
            this.btn_ModifyOrder.UseVisualStyleBackColor = false;
            this.btn_ModifyOrder.Click += new System.EventHandler(this.btn_ModifyOrder_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ShowAll.Location = new System.Drawing.Point(402, 15);
            this.ShowAll.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(140, 36);
            this.ShowAll.TabIndex = 0;
            this.ShowAll.Text = "显示全部订单\r\n";
            this.ShowAll.UseVisualStyleBackColor = false;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(71, 30);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagerInfo});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(80, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ManagerInfo
            // 
            this.ManagerInfo.Name = "ManagerInfo";
            this.ManagerInfo.Size = new System.Drawing.Size(200, 34);
            this.ManagerInfo.Text = "管理员信息";
            this.ManagerInfo.Click += new System.EventHandler(this.管理系统的信息ToolStripMenuItem_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.searchType);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.btnQueryOrder);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 106);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1178, 55);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // searchType
            // 
            this.searchType.DropDownWidth = 240;
            this.searchType.FormattingEnabled = true;
            this.searchType.Items.AddRange(new object[] {
            "按订单号查询",
            "按商品名称查询",
            "按客户名查询"});
            this.searchType.Location = new System.Drawing.Point(10, 15);
            this.searchType.Margin = new System.Windows.Forms.Padding(10, 15, 3, 4);
            this.searchType.Name = "searchType";
            this.searchType.Size = new System.Drawing.Size(240, 26);
            this.searchType.TabIndex = 1;
            this.searchType.Text = "订单查询方式";
            this.searchType.SelectedIndexChanged += new System.EventHandler(this.searchType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "订单号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 28);
            this.textBox1.TabIndex = 3;
            // 
            // btnQueryOrder
            // 
            this.btnQueryOrder.Location = new System.Drawing.Point(559, 15);
            this.btnQueryOrder.Margin = new System.Windows.Forms.Padding(25, 15, 3, 3);
            this.btnQueryOrder.Name = "btnQueryOrder";
            this.btnQueryOrder.Size = new System.Drawing.Size(120, 30);
            this.btnQueryOrder.TabIndex = 3;
            this.btnQueryOrder.Text = "查询订单\r\n";
            this.btnQueryOrder.UseVisualStyleBackColor = true;
            this.btnQueryOrder.Click += new System.EventHandler(this.btnQueryOrder_Click);
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.OrderList);
            this.groupBoxOrder.Location = new System.Drawing.Point(0, 167);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(667, 373);
            this.groupBoxOrder.TabIndex = 3;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "订单";
            // 
            // OrderList
            // 
            this.OrderList.AllowUserToAddRows = false;
            this.OrderList.AllowUserToDeleteRows = false;
            this.OrderList.AutoGenerateColumns = false;
            this.OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderTime,
            this.CustomerName,
            this.Address,
            this.TotalPrice,
            this.orderIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.OrderList.DataSource = this.orderBindingSource;
            this.OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderList.Location = new System.Drawing.Point(3, 24);
            this.OrderList.MultiSelect = false;
            this.OrderList.Name = "OrderList";
            this.OrderList.ReadOnly = true;
            this.OrderList.RowHeadersWidth = 62;
            this.OrderList.RowTemplate.Height = 30;
            this.OrderList.Size = new System.Drawing.Size(661, 346);
            this.OrderList.TabIndex = 0;
            this.OrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderList_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(673, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单明细";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.SinglePrice,
            this.ProductNum,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(499, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // ItemBindingSource
            // 
            this.ItemBindingSource.DataMember = "Details";
            this.ItemBindingSource.DataSource = this.orderBindingSource;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderId";
            this.OrderID.HeaderText = "订单号";
            this.OrderID.MinimumWidth = 8;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 120;
            // 
            // OrderTime
            // 
            this.OrderTime.DataPropertyName = "OrderTime";
            this.OrderTime.HeaderText = "下单时间";
            this.OrderTime.MinimumWidth = 8;
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.ReadOnly = true;
            this.OrderTime.Width = 120;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "客户名";
            this.CustomerName.MinimumWidth = 8;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 120;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 120;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalAmount";
            this.TotalPrice.HeaderText = "总价";
            this.TotalPrice.MinimumWidth = 8;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 120;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "商品名称";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
            // 
            // SinglePrice
            // 
            this.SinglePrice.DataPropertyName = "Price";
            this.SinglePrice.HeaderText = "单价";
            this.SinglePrice.MinimumWidth = 8;
            this.SinglePrice.Name = "SinglePrice";
            this.SinglePrice.ReadOnly = true;
            this.SinglePrice.Width = 140;
            // 
            // ProductNum
            // 
            this.ProductNum.DataPropertyName = "Quantity";
            this.ProductNum.HeaderText = "数量";
            this.ProductNum.MinimumWidth = 8;
            this.ProductNum.Name = "ProductNum";
            this.ProductNum.ReadOnly = true;
            this.ProductNum.Width = 140;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "orders";
            this.orderBindingSource.DataSource = typeof(WindowsFormsApp1.OrderService);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.itemBindingSourse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "订单管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.itemBindingSourse.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBoxOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel itemBindingSourse;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Button btn_ModifyOrder;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox searchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnQueryOrder;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.DataGridView OrderList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource ItemBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ManagerInfo;
        private System.Windows.Forms.Button btn_DeleteOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinglePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}

