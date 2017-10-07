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
            Conversation();

            Console.WriteLine("Now let's play some music :)");
            Console.WriteLine();
            Console.WriteLine("Press 1 to skip song");
            Console.WriteLine("Press 2 to hear HotCrossedBuns");
            Console.WriteLine("Press 3 to hear Twinkle Twinkle Little Star");

            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.WriteLine("Ok, no need for beutiful music today... :)");
            }
            else if (answer == "2")
            {
                HotCrossedBuns();
            }
            else if (answer == "3")
            {
                TwinkleTwinkle();
            }
            Console.ReadLine();
        }

        static private void Conversation()
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

        static public void M(int f, double t)
        {
            int bar = 500;
            int time = Convert.ToInt32(bar * t);
            Console.Beep(f, time);
        }

        static public void HotCrossedBuns()
        {
            int c = 1046;
            int d = 1174;
            int e = 1318;
            M(e, 1);
            M(d, 1);
            M(c, 2);
            M(e, 1);
            M(d, 1);
            M(c, 2);
            M(c, 0.5);
            M(c, 0.5);
            M(c, 0.5);
            M(c, 0.5);
            M(d, 0.5);
            M(d, 0.5);
            M(d, 0.5);
            M(d, 0.5);
            M(e, 1);
            M(d, 1);
            M(c, 2);
        }

        static public void TwinkleTwinkle()
        {
            int c = 1046;
            int d = 1174;
            int e = 1318;
            int f = 1396;
            int g = 1567;
            int a = 1760;

            M(c, 1);
            M(c, 1);
            M(g, 1);
            M(g, 1);

            M(a, 1);
            M(a, 1);
            M(g, 2);

            M(f, 1);
            M(f, 1);
            M(e, 1);
            M(e, 1);


            M(d, 1);
            M(d, 1);
            M(c, 2);

            M(g, 1);
            M(g, 1);
            M(f, 1);
            M(f, 1);

            M(e, 1);
            M(e, 1);
            M(d, 2);

            M(g, 1);
            M(g, 1);
            M(f, 1);
            M(f, 1);

            M(e, 1);
            M(e, 1);
            M(d, 2);

            M(c, 1);
            M(c, 1);
            M(g, 1);
            M(g, 1);

            M(a, 1);
            M(a, 1);
            M(g, 2);

            M(f, 1);
            M(f, 1);
            M(e, 1);
            M(e, 1);

            M(d, 1);
            M(d, 1);
            M(c, 2);
            


        }
    }
}