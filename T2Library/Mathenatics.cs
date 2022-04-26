using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2Library
{
    public class Mathematics
    {
        private int x;
        
        public int X { get { return x; } set { x = value; } }
        

        public int Factorial(int value)
        {
            if (value < 0)
            {
                throw new UserException("Факториал определен для не отрицательных чисел");
            }
            if (value is decimal || value is float || value is double)
            {
                throw new UserException("Факториал определен для целых чисел");
            }
            X = 1;
            for (int i = 1; i < value+1; i++)
            {
                X *= i;
            }
            return X;
        }
        public int Exponent (int a, int b)
        {
            if (!(a is int) || !(b is int))
            {
                throw new UserException("Введены не числовые значения");
            }
            X = a;
            for (int i = 1; i < b; i++)
            {
                X *= a;
            }
            return X;
        }
    }
}
