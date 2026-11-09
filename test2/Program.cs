using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            int age = int Console.ReadLine();
            Console.WriteLine($"Hoi {name}, je bent {age} jaar oud!");
            Console.ReadLine();
        }
    }
}
