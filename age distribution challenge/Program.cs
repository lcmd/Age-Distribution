using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_distribution_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "19";

            int number = int.Parse(line);
            if (number >= 0 && number <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (number >= 3 && number <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (number >= 5 && number <= 11)
            {
                Console.WriteLine("Elementary school");
            }
            else if (number >= 12 && number <= 14)
            {
                Console.WriteLine("Middle school");
            }
            else if (number >= 15 && number <= 18)
            {
                Console.WriteLine("High school");
            }
            else if (number >= 19 && number <= 22)
            {
                Console.WriteLine("College");
            }
            else if (number >= 23 && number <= 65)
            {
                Console.WriteLine("Working for the man");
            }
            else if (number >= 66 && number <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans");
        
        }
        }
    }
}
