using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Mathh
    {
         const double PI = 3.14;
         const double E = 2.71;

        public double Abs(double x)
        {
            if(x>0)
            {
                return x;
            }    
            else
            {
                return -x;
            }
        }
        public float Abs(float x)
        {
            if (x > 0)
            {
                return x;
            }
            else
            {
                return -x;
            }
        }
        public int Abs(int x)
        {
            if (x > 0)
            {
                return x;
            }
            else
            {
                return -x;
            }
        }
        public double Pow(double x, double y)
        {
            for (int i=1; i<=y; i++)
            {
                x = x*i;
            }
            return x;
        }
        public double Sqrt(double d)
        {
            return Math.Sqrt(d);
        }
        public int Max(int val1, int val2)
        {
            if(val1>val2)
            {
                return val1;
            }
            else if (val2>val1)
            {
                return val2;
            }
            else
            {
                return 0;
            }
        }
        public int Min(int val1, int val2)
        {
            if (val1 < val2)
            {
                return val1;
            }
            else if (val2 < val1)
            {
                return val2;
            }
            else
            {
                return 0;
            }
        }
    }
    
}
