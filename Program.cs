using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main()
        {
            // Initialise random variable
            Random myrnd = new Random();
            
            // For loop
            for (int i = 1; i<=10; i++)
            {
                // Initialise variable
                int mynumber = myrnd.Next(1, 100);
                if (mynumber % 2 == 0)
                    Console.WriteLine($"{mynumber} is an even number");
                else
                    Console.WriteLine($"{mynumber} is an odd number");
            }
            
        }
    }
}
