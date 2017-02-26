using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHElloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speak your mind!");
            string message = Console.ReadLine();
            Console.WriteLine($"Your message was: {message}" + Environment.NewLine + "Thank you!");
            Console.ReadKey();
        }
    }
}
