using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nHi " + name);

            Console.WriteLine("\nEnter you age: ");
            string age = Console.ReadLine();

            Console.WriteLine("\nYou are " + age + " years.");

            //Freeze the console
            Console.ReadLine();
        }
    }
}
