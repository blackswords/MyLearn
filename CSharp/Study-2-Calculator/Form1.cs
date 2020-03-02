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
        /// <summary>
        /// true 为正数， false 为负数
        /// </summary>
        private bool flag;
        private Calculator calculator;

        public Form1()
        {
            flag = true;
            calculator = new Calculator();
            InitializeComponent();
        }

        /// <summary>
        /// 操作方法
        /// </summary>
        /// <param name="str">传入的按钮内容</param>
        private void FormCalculator(String str)
        {
            if (this.calculator != null)
            {
                calculator.Operation(str);
            }
            this.label1.Text = this.calculator.ShowText;
        }

        /// <summary>
        /// 正负号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            this.FormCalculator("+/-");
        }

        /// <summary>
        /// 退位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.FormCalculator("DEL");
        }

        /// <summary>
        /// CE置零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.FormCalculator("CE");
        }

        /// <summary>
        /// 置零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.FormCalculator("C");
        }

        /// <summary>
        /// 除号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.FormCalculator("/");
        }

        /// <summary>
        /// 乘号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            this.FormCalculator("*");
        }

        /// <summary>
        /// 减号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            this.FormCalculator("-");
        }

        /// <summary>
        /// 加号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            this.FormCalculator("+");
        }

        /// <summary>
        /// 等号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button20_Click(object sender, EventArgs e)
        {
            this.FormCalculator("=");
        }

        //数字键7 8 9 4 5 6 1 2 3 0 .
        private void button5_Click(object sender, EventArgs e)
        {
            this.FormCalculator("7");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.FormCalculator("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.FormCalculator("9");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.FormCalculator("4");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.FormCalculator("5");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.FormCalculator("6");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.FormCalculator("1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.FormCalculator("2");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.FormCalculator("3");
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            this.FormCalculator("0");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.FormCalculator(".");
        }
    }
}
