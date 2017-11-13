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


            Print("Vil du gerne mine dimonds??");
            string valg = Console.ReadLine().ToLower();
            Print("Hvor mange blocks, vil du gerne mine ned??");
            int blocks = int.Parse(Console.ReadLine());

            if(valg == "ja")
            {
                Mine(blocks);
            }
            
            
            Console.ReadKey();
        }
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
        public static void Mine(int blocks)
        {
            if(blocks < 100)
            {
                Console.WriteLine("Du har valgt at mine " + blocks + " ned");
                Console.WriteLine("Du fandt 1000 dimonds");
            } else
            {
                Console.WriteLine("Nå");
                Console.WriteLine("Så langt måtte du ikke mine");
            }
            
        }
    }
}
