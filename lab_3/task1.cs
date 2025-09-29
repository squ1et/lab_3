using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class task1
    {
        private int a;
        private int b;
        private int c;

        public task1()
        {
            a = b = c = 27;
        }

        public task1(int a)
        {
            this.a = a;
            b = c = 27;
        }

        public task1(int a, int b)
        {
            this.a = a;
            this.b = b;
            c = 27;
        }

        public task1(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public int GetNumOfMultiples()
        {
            int count = 0;
            if (a % 27 == 0) count++;
            if (b % 27 == 0) count++;
            if (c % 27 == 0) count++;
            return count;
        }

    }
}
