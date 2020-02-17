using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitOfCombox();
        }
        private void InitLabel()
        {
            label1.Text = "";
        }
        private void InitOfCombox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            for ( int i=1; i<=36; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
                comboBox5.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitOfCombox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = true;

            int[] seletNumber = new int[5];
            seletNumber[0] = comboBox1.SelectedIndex;
            seletNumber[1] = comboBox2.SelectedIndex;
            seletNumber[2] = comboBox3.SelectedIndex;
            seletNumber[3] = comboBox4.SelectedIndex;
            seletNumber[4] = comboBox5.SelectedIndex;
            for ( int i=4;i>1; i--)
            {
                for( int j=i; j>=0; j--)
                {
                    if( flag && seletNumber[i] < seletNumber[j])
                    {
                        int t = seletNumber[i];
                        seletNumber[i] = seletNumber[j];
                        seletNumber[j] = t;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
            }

            Luck myLuck = new Luck();
            int[] luck = myLuck.GetLuckArray();
            if (flag)
            {
                
                for (int i = 4; i > 1; i--)
                {
                    for (int j = i; j >= 0; j--)
                    {
                        if (luck[i] < luck[j])
                        {
                            int t = luck[i];
                            luck[i] = luck[j];
                            luck[j] = t;
                        }
                    }
                }
                for(int i=0; i<5; i++)
                {
                    if(luck[i] != seletNumber[i])
                    {
                        flag = false;
                    }
                }

                if(flag)
                {
                    label1.Text = "Luck! 恭喜您中奖了！";
                }
            }

            else
            {
                label1.Text = "很遗憾，您没有中奖\n本次的开奖码为：" +
                    luck[0] + "  " + luck[1] + "  " + luck[2] + "  " + luck[3] + "  " + luck[4];
            }
        }
    }
}
