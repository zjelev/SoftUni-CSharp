﻿using System;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void PrintSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("The number " + n + " is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine("The number " + n + " is negative.");
            }
            else
            {
                Console.WriteLine("The number " + n + " is zero.");
            }

        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}