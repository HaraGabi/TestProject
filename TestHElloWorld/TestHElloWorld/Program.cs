﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHElloWorld
{
    class Program
    {
        public static string Greetings() => "Hello!";
        static void Main(string[] args)
        {
            Console.WriteLine(Greetings());
            Console.WriteLine("Belediteltem!");
            Console.WriteLine("MArhas");
            string message = Console.ReadLine();
            Console.Title = "HIHI";
            Console.WriteLine($"Your message was: {message}" + Environment.NewLine + "Thank you!");
            Console.ReadKey();
        }
    }
}
