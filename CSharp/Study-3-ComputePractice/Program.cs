/**
 * 写于2020-3-2
 * 完成于23点46分
 * From：罗庆宏
 * 感谢您的帮助，谢谢。
 * 本程序是基于vs2019  .NET Framework4.7.2编写
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
