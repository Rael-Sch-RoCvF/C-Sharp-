using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is jouw naam?");
            String name = Console.ReadLine();
            Console.WriteLine("How oud ben jij?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hoi {name}, je bent {age} jaar oud!");
            Console.ReadLine();
        }
    }
}
