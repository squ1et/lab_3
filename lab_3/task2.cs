using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class task2
    {
        private int a, b;

        public int A => a; 
        public int B => b;

        public task2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int CalcSum()
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 17 == 0 && i % 4 == 2) sum += i;
            }
            return sum;
        }
    }
}
