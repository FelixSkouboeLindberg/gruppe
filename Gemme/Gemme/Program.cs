using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Print("Do u like mining dimonds???");
            string answer = Console.ReadLine();
            
            if (answer == "yes")
            {
                Print("FeelsGoodMan");
            }
            else
            {
                Print("You suck");
            }

            Console.ReadKey();
        }
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
