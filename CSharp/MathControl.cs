using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MathControl
    {
        static int gcd(int a, int b)
        {
            if (a % b == 0)
                return b;
            if (a < b)
                return gcd(b, a);
            else
                return gcd(b, a % b);
        }

        /// <summary>
        /// 移位除法
        /// </summary>
        /// <param name="first">被除数</param>
        /// <param name="second">除数</param>
        /// <param name="quotient">商</param>
        /// <param name="remainder">余数</param>
        static void Division(int first, int second, ref int quotient, ref int remainder)
        {
            bool flag = true, flbg = true;
            if (second == 0)
                return;
            if (first < 0)
            {
                flag = false;
                first = -first;
            }
            if (second < 0)
            {
                flbg = false;
                second = -second;
            }

            quotient = 0;
            remainder = 0;
            int temp = second;
            int show = 1;
            while (first >= temp)
            {
                temp <<= 1;
                if (temp <= first)
                    show <<= 1;
                else
                {
                    quotient += show;
                    temp >>= 1;
                    first -= temp;
                    temp = second;
                    show = 1;
                }
            }
            remainder = first;
            if (flag ^ flbg)
                quotient = -quotient;
            if (!flag)
                remainder = -remainder;
        }
        /// <summary>
        /// 基于Division算法的求余算法
        /// </summary>
        /// <param name="first">被除数</param>
        /// <param name="second">除数</param>
        /// <returns>余数</returns>
        static int Mod(int first, int second)
        {
            int remainder = 0;
            int tem = 0;
            Division(first, second, ref tem, ref remainder);
            return remainder;
        }
        /// <summary>
        /// 基于Mod方法的最小公约数算法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>最小公约数</returns>
        static int JustGcd(int a, int b)
        {
            if (a < b)
                return JustGcd(b, a);
            if (a % b != 0)
                return JustGcd(b, Mod(a, b));
            else
                return b;
        }
    }
}
