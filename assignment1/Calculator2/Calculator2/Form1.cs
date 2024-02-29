using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //得出结果
        private void result_Click(object sender, EventArgs e)
        {
            double num2;
            double num1=double.Parse(textBox4.Text);
            if (textBox1.Text == "") num2 = 0;
            else num2= double.Parse(textBox1.Text);

            if (jia.Enabled == false) {
                textBox4.Text = "Rusult:";
                textBox1.Text=Convert.ToString(num1+num2);
                jia.Enabled = true;
            }
             if (jian.Enabled == false) {
                textBox4.Text = "Rusult:";
                textBox1.Text=Convert.ToString(num1-num2);
                jian.Enabled = true;
            }
            if (cheng.Enabled == false)
            {
                textBox4.Text = "Rusult:";
                textBox1.Text = Convert.ToString(num1 * num2);
                cheng.Enabled = true;
            }
            if (chu.Enabled == false)
            {
                if (num2 != 0)
                {
                    textBox4.Text = "Rusult:";
                    textBox1.Text = Convert.ToString(num1 / num2);
                    chu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("0不能作除数","错误提示");
                    textBox1.Text = "";
                    return;
                }
            }

            if (mod.Enabled == false)
            {
                double s=double.Parse(textBox1.Text);   
                int a=(int)s;   
                if(a!= s)
                {
                    MessageBox.Show("小数不能取余");
                    textBox1.Text = "";
                    return;
                }
                else
                {
                    textBox4.Text = "Rusult:";
                    textBox1.Text = Convert.ToString(num1 + num2);
                    mod.Enabled = true;   

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        //加号
        private void button15_Click(object sender, EventArgs e)
        {
            chu.Enabled = true;  
            cheng.Enabled = true;
            jia.Enabled = false;
            jian.Enabled = true;
            if (textBox1.Text != "")
            {
                textBox4.Text = textBox1.Text;
                textBox1.Text = "";

            }
            else textBox4.Text = "0";
        }
        private void point_Click(object sender, EventArgs e)  //小数点按键
        {
            if (textBox1.Text.Contains(".")) return;
            else
            {
                if (textBox1.Text != "") textBox1.Text += ".";
            }
        }

        //输出的框
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //输入的框
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        //÷按键
        private void chu_Click(object sender, EventArgs e)
        {
            chu.Enabled = false;  //在点击÷后就不能再次点击
            cheng.Enabled = true;
            jia.Enabled = true;
            jian.Enabled = true;
            if (textBox1.Text != "")
            {
                textBox4.Text = textBox1.Text;
                textBox1.Text = "";

            }
            else textBox4.Text = "0";
        }

        private void cheng_Click(object sender, EventArgs e)
        {
            chu.Enabled = true;  
            cheng.Enabled = false;
            jia.Enabled = true;
            jian.Enabled = true;
            if (textBox1.Text != "")
            {
                textBox4.Text = textBox1.Text;
                textBox1.Text = "";

            }
            else textBox4.Text = "0";

        }

        private void jian_Click(object sender, EventArgs e)
        {
            chu.Enabled = true; 
            cheng.Enabled = true;
            jia.Enabled = true;
            jian.Enabled = false;
            if (textBox1.Text != "")
            {
                textBox4.Text = textBox1.Text;
                textBox1.Text = "";

            }
            else textBox4.Text = "0";
        }

        //mod按键_取余数
        private void mod_Click(object sender, EventArgs e)
        {
            double s=double.Parse(textBox1.Text); //利用parse方法将输入的文本转化成浮点数类型  
            int a = (int)s;
            if (a != s)
            {
                MessageBox.Show("小数不能取余");  //错误输入，将弹出一个对话框
                textBox1.Text= " ";
                return;
            }
            else{
                chu.Enabled = true;
                cheng.Enabled = true;
                jia.Enabled = true;
                jian.Enabled = true;
                mod.Enabled = false;
                if(textBox1.Text !="")
                {
                    textBox4.Text = textBox1.Text;
                    textBox1.Text = "";
                }
                else textBox4.Text = "0";

            }
        }

        //clear按键
        private void botten_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            chu.Enabled = true;
            cheng.Enabled = true;
            jia.Enabled = true;
            jian.Enabled = true;
        }

        //back按键，进行回退
        private void button_back_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);  //将输入的内容长度减一
            else return;
        }

    }
}
