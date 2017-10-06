using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Let's play a little game!");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi {0}! How are you today?", name);
            string feeling = Console.ReadLine();
            Console.WriteLine("Yes, well, I'm feeling {0} a bit also... but probably not as "
                + "much as you!", feeling);
            Console.WriteLine();
            Console.WriteLine("{0} is {1}", name, feeling);
            Console.ReadLine();
        }
    }
}
