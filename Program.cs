﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoril
{
    internal class Program
    {
        static void Main(string[] args)
        {//سالار رحیمی ،فاکتوریل
            Console.Write(" number: ");
            int number = int.Parse(Console.ReadLine());
            int fact = 1, n = 1;
            while (n <= number)
            {
                fact *= n;
                n++;
            }
            Console.WriteLine("\n{0}! = {1}\n\n", number, fact);
            Console.ReadKey( );
        }
    }
}
