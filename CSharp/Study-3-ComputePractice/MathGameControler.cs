using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    class MathGameControler
    {
        public enum MathTypeStates
        {
            ten, twenty, mul
        }
        /// <summary>
        /// 计算类型
        /// </summary>
        private MathTypeStates type;
        /// <summary>
        /// 显示文本
        /// </summary>
        private string showText;
        /// <summary>
        /// 答案
        /// </summary>
        private string answer;
        /// <summary>
        /// 速度等级
        /// </summary>
        private int speedLevel;
        /// <summary>
        /// 是否自动更新题目
        /// </summary>
        private bool isAutoUpdateSubject;
        /// <summary>
        /// 是否自动显示正确答案
        /// </summary>
        private bool isAutoShowAnswer;
        /// <summary>
        /// 速度，单位：s
        /// </summary>
        private int[] speed = { 5, 10, 15, 20, 25 };

        public MathTypeStates Type { get => type; set => type = value; }
        public string ShowText { get => showText; set => showText = value; }
        public string Answer { get => answer; set => answer = value; }
        public int SpeedLevel { get => speedLevel; set => speedLevel = value; }
        public bool IsAutoUpdateSubject { get => isAutoUpdateSubject; set => isAutoUpdateSubject = value; }
        public bool IsAutoShowAnswer { get => isAutoShowAnswer; set => isAutoShowAnswer = value; }

        public MathGameControler()
        {
            type = MathTypeStates.ten;
            isAutoShowAnswer = true;
            isAutoUpdateSubject = true;
            speedLevel = 2;
            showText = "";
            answer = "";

            CreateNewSubject();
        }

        /// <summary>
        /// 创建新的算式
        /// </summary>
        public void CreateNewSubject()
        {
            int first, second;
            int maxNum = 0;
            char symbol = '+';
            Random random = new Random();

            //根据当前模式状态建立基本数据
            switch (this.Type)
            {
                case MathTypeStates.ten:
                    maxNum = 10;
                    symbol = '+';
                    break;
                case MathTypeStates.twenty:
                    maxNum = 20;
                    symbol = '+';
                    break;
                case MathTypeStates.mul:
                    maxNum = 10;
                    symbol = '*';
                    break;
            }

            //随机获取两个数字
            first = random.Next(0, maxNum);
            second = random.Next(0, maxNum);

            //根据符号，开始计算，更新showText，结果保存于first
            switch (symbol)
            {
                case '+':
                    this.ShowText = first + " + " + second + " = ?";
                    first = first + second;
                    break;
                case '*':
                    this.ShowText = first + " * " + second + " = ?";
                    first = first * second;
                    break;
            }

            //更新answer
            this.Answer = first.ToString();

        }

        /// <summary>
        /// 正确判定
        /// </summary>
        /// <param name="yourAnswer"></param>
        /// <returns></returns>
        public bool Judge(string yourAnswer)
        {
            if (this.Answer.Equals(yourAnswer))
                return true;
            return false;
        }
        /// <summary>
        /// 加速
        /// </summary>
        public void UpSpeed()
        {
            if (this.SpeedLevel > 0)
                this.SpeedLevel--;
        }
        /// <summary>
        /// 减速
        /// </summary>
        public void DownSpeed()
        {
            if (this.SpeedLevel < 4)
                this.SpeedLevel++;
        }
        /// <summary>
        /// 获取当前速度
        /// </summary>
        /// <returns></returns>
        public int GetNowSpeed()
        {
            return speed[SpeedLevel];
        }
    }
}
