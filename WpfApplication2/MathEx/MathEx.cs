﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.MathEx
{
    static class MathEx
    {
        public static int Addition(params int[] numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
            
        }

        public static int Addition(List<int> numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        internal static int Multiply(int v)
        {
            return 0;
        }

        internal static int Subtract(int v)
        {
            return 0;
        }

        internal static int Divide(int v)
        {
            return 0;
        }
    }
}
