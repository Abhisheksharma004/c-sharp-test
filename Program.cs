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
            Console.WriteLine("Enter Your Marks : !");

            //Console.ReadLine();
            //Console.WriteLine("Hello Abhishek"); Console.ReadLine();
            
            int age = 100;

            if (age >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (age >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (age >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
            

        }
    }
}
