﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub!");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Loop Number " + (i + 1));
            }
            Console.ReadKey();
        }
    }
}
