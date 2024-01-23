using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kak ti e purvoto ime");
            string name1 = Console.ReadLine();
            string cocktail1 = "Vodka + Martini + Cherry";
            string a = "whisky";

            Console.WriteLine(name1);
            Console.WriteLine(cocktail1);
            Console.WriteLine(a);
            Console.WriteLine(name1 +"ste pie"+cocktail1+"i"+a);
            string name2 = cocktail1.Replace("+", " ");
            string name = name2.Remove(1, 4);
            
            Console.WriteLine(name);
            
            string lowerAlpha = name.ToString();
            Console.WriteLine(lowerAlpha);

            string upperAlpha = name1.ToString();
            Console.WriteLine(upperAlpha);

            string novo1 = a.Replace("voda,", " Martini");
            string ToUpper= name1.ToUpper();
            Console.WriteLine(upperAlpha);

            string novo2 = name2.Remove(10, 4);
            Console.WriteLine(name2);
        }
    }
}
