/**
 * 这个文件中所使用的类：Calculator是一个计算器控制类
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calculator
    {
        private String showText;
        private String beComputedNumberTemp;
        private String computedNumberTemp;
        private String lastSymbol;
        public string ShowText { get => showText; set => showText = value; }
        public string BeComputedNumberTemp { get => beComputedNumberTemp; set => beComputedNumberTemp = value; }
        public string ComputedNumberTemp { get => computedNumberTemp; set => computedNumberTemp = value; }
        public string LastSymbol { get => lastSymbol; set => lastSymbol = value; }

        public Calculator()
        {
            Init();
        }

        /// <summary>
        /// 初始化成员
        /// </summary>
        private void Init()
        {
            ShowText = "0";
            BeComputedNumberTemp = "0";
            computedNumberTemp = "0";
            LastSymbol = "+";
        }

        /// <summary>
        /// 操作索引方法
        /// </summary>
        /// <param name="op"></param>
        public void Operation(string op)
        {
            if (this.LastSymbol.Equals("P"))
                Init();
            switch (op) 
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case ".":
                    this.UpdateNowNumber(op);
                    break;
                case "+/-":
                    this.ChangePlusOrMinus();
                    break;
                case "*":
                case "/":
                case "+":
                case "-":
                    Calculation(op);
                    break;
                case "=":
                    this.Result();
                    break;
                case "CE":
                case "C":
                    this.Reset();
                    break;
                case "DEL":
                    this.Deletion();    
                    break;

            }
        }

        /// <summary>
        /// 退位方法
        /// </summary>
        public void Deletion()
        {
            if (!this.ComputedNumberTemp.Equals("0"))
            {
                this.ComputedNumberTemp = this.ComputedNumberTemp.Substring(0, this.ComputedNumberTemp.Length - 1);
            }
            UpdateShowText();
        }
        /// <summary>
        /// 计算方法
        /// </summary>
        /// <param name="symbol"></param>
        public void Calculation(String symbol)
        {
            
            this.Result();
            this.LastSymbol = symbol;
            this.ComputedNumberTemp = "0";
        }
        /// <summary>
        /// 重置算法
        /// </summary>
        public void Reset()
        {
            this.Init();
        }
        /// <summary>
        /// 求结果方法
        /// </summary>
        public void Result()
        {
            long first, second;
            first = System.Convert.ToInt64(this.BeComputedNumberTemp);
            second = System.Convert.ToInt64(this.ComputedNumberTemp);
            if (LastSymbol.Equals("+"))
                first = first + second;
            else if (LastSymbol.Equals("-"))
                first = first - second;
            else if (LastSymbol.Equals("*"))
                first = first * second;
            else if (LastSymbol.Equals("/"))
                first = first / second;

            this.BeComputedNumberTemp = first.ToString();
            this.ComputedNumberTemp = first.ToString();
            this.LastSymbol = "P";
            UpdateShowText();
            
        }
        /// <summary>
        /// 更新当前控制数字方法
        /// </summary>
        /// <param name="str"></param>
        public void UpdateNowNumber(string str)
        {
            //competedNumber
            if (this.ComputedNumberTemp.Equals("0"))
                this.ComputedNumberTemp = str;
            else
                this.ComputedNumberTemp += str;
            this.UpdateShowText();
        }
        /// <summary>
        /// 更新显示文本方法
        /// </summary>
        public void UpdateShowText()
        {
            this.ShowText = this.ComputedNumberTemp;
        }
        /// <summary>
        /// 正负切换
        /// </summary>
        public void ChangePlusOrMinus()
        {
            bool flag = this.ComputedNumberTemp.Contains("-");
            if (flag)
                this.ComputedNumberTemp = this.ComputedNumberTemp.Substring(1);
            else
                this.ComputedNumberTemp = "-" + this.ComputedNumberTemp;

            this.UpdateShowText();
        }
    }
}
