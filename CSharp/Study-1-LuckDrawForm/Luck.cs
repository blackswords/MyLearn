using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckForm
{
    class Luck
    {
        private int[] allNumber;

        public Luck()
        {
            allNumber = new int[36];
            for( int i=0; i<36; i++)
            {
                allNumber[i] = i + 1;
            }

            Random random = new Random();

            for( int i=35; i>=0; i--)
            {
                int ax;
                ax = random.Next(0, 35);

                int t = allNumber[i];
                allNumber[i] = allNumber[ax];
                allNumber[ax] = t;
            }
        }

        public int[] GetLuckArray()
        {
            int[] luck = new int[5];
            for( int i=0; i<5; i++)
            {
                luck[i] = this.allNumber[i];
            }

            return luck;
        }
    }
}
