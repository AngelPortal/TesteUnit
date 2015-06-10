using System;
using System.Collections.Generic;
using System.Text;

namespace TestNUnit
{
    public class MyTest
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Substract(int a, int b)
        {
            return a - b;
        }
        public int Devide(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Function(int a, int b)
        {
            return a*b + a/b - b;
        }
    }
}
