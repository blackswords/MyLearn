/**
 * 写于2020-3-2
 * 完成于23点46分
 * From：罗庆宏
 * 感谢您的帮助，谢谢。
 * 本程序是基于vs2019  .NET Framework4.7.2编写
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
        private MathGameControler gameCtrl;
        private string answertext;
        private int score = 0;
        private int awardScore = 1;
        private int sec = 0;
        private bool isChecked;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类型单选组 信号检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTen.Checked)
                gameCtrl.Type = MathGameControler.MathTypeStates.ten;
            if (rbtnTwenty.Checked)
                gameCtrl.Type = MathGameControler.MathTypeStates.twenty;
            if (rbtnMultiplication.Checked)
                gameCtrl.Type = MathGameControler.MathTypeStates.mul;
        }

        /// <summary>
        /// 加速按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFast_Click(object sender, EventArgs e)
        {
            gameCtrl.UpSpeed();
        }

        /// <summary>
        /// 减速按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSlow_Click(object sender, EventArgs e)
        {
            gameCtrl.DownSpeed();
        }
        /// <summary>
        /// 勾选框 自动刷新题目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAutoSubject_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAutoSubject.Checked)
                gameCtrl.IsAutoUpdateSubject = true;
            else
                gameCtrl.IsAutoUpdateSubject = false;
        }
        /// <summary>
        /// 勾选框 自动显示答案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAutoShowAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAutoShowAnswer.Checked)
                gameCtrl.IsAutoShowAnswer = true;
            else
                gameCtrl.IsAutoShowAnswer = false;
        }
        /// <summary>
        /// 建立下一个题目内容
        /// </summary>
        private void NextSubject()
        {
            //更新待更新内容
            if (this.gameCtrl == null)
            {
                this.gameCtrl = new MathGameControler();
            }
            this.gameCtrl.CreateNewSubject();
            this.labSubject.Text = gameCtrl.ShowText;
            this.sec = gameCtrl.GetNowSpeed();
            this.label1.Text = sec.ToString();
            this.isChecked = false;
            this.answerBox.Text = "";
        }
        /// <summary>
        /// 答案检查，show、tip计时器更新，颜色改变，分数改变
        /// </summary>
        private void checkAnswer()
        {
            this.isChecked = true;
            //答案判定
            if (gameCtrl.Judge(answertext))
            {
                this.answerBox.BackColor = Color.LightGreen;
                this.labelRight.Text = "You Are Right!";
                this.labelRight.Visible = true;
                this.score += this.awardScore;
                this.awardScore++;
            }
            else
            {
                this.answerBox.BackColor = Color.LightPink; 
                this.labelRight.Text = "Right Answer: " + gameCtrl.Answer;
                if (gameCtrl.IsAutoShowAnswer)
                    this.labelRight.Visible = true;
                this.awardScore = 1;
            }
            this.labScore.Text = "Score: " + this.score;
            //更新计时器
            timerShow.Enabled = true;
            timerShow.Start();
            timerTip.Enabled = true;
            timerTip.Start();
        }
        /// <summary>
        /// 文本框背景恢复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void backView(object sender, EventArgs e)
        {
            this.answerBox.BackColor = Color.White;
            timerShow.Stop();
        }
        /// <summary>
        /// 提示信息计时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void tipChanges(object sender, EventArgs e)
        {
            this.labelRight.Text = "Right Answer: ";
            this.labelRight.Visible = false;
            timerTip.Stop();
        }
        /// <summary>
        /// 输入框信号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerBox_TextChanged(object sender, EventArgs e)
        {
            this.answertext = this.answerBox.Text;
        }

        /// <summary>
        /// 键盘按键监测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerBox_KeyPressDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                answertext = answerBox.Text;
                if (isChecked == false)
                    checkAnswer();
                if (gameCtrl.IsAutoUpdateSubject)
                    NextSubject();
            }
        }
        /// <summary>
        /// 计时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSec_Tick(object sender, EventArgs e)
        {
            if (sec > 0)
                sec--;
            this.label1.Text = this.sec.ToString();
            if( sec <=0)
            {
                if (isChecked == false)
                    checkAnswer();
                if (gameCtrl.IsAutoUpdateSubject)
                    NextSubject();
            }
        }
        /// <summary>
        /// Next按钮信号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text.Equals("游戏开始"))
            {
                //总计时器开始计时
                this.timerSec.Enabled = true;
                //按钮文字更新
                this.btnNext.Text = "下一题";
                //更新分数
                this.labScore.Text = "Score: 0";
            }
            else
                if (isChecked == false)
                    checkAnswer();
            NextSubject();
        }

    }
}
