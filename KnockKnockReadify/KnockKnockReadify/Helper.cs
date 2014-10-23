using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnockReadify
{
    public class Helper
    {
        public static long Fibonacci(long number)
        {
            if (number == 0)
                return 0;

            if (number > 92)
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");

            long[] Fib = new long[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            for (long i = 2; i <= number; i++)
                Fib[i] = Fib[i - 2] + Fib[i - 1];

            return Fib[number];
        }

        public static string ReverseWords(string str)
        {
            if (str == null)
                throw new ArgumentNullException("s", "Value cannot be null");

            var reversedWords = string.Join(" ",
              str.Split(' ')
                 .Select(x => new String(x.Reverse().ToArray()))
                 .ToArray());

            return reversedWords;
        }

        public static TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if ((a >= (b + c)) || (b >= (a + c)) || (c >= (a + b)))
                return (TriangleType)0;

            else if (a == b && b == c)
                return (TriangleType)1;

            else if (a == b || a == c || b == c)
                return (TriangleType)2;

            else
                return (TriangleType)3;
        }
    }
}