using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Deliverable_One
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            bool money = true;
            do
            {
                double numone;
                double numtwo;
                double numthree;
                Console.WriteLine("Please enter your first dollar amount");
                numone = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second dollar amount");
                numtwo = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the last dollar amount please");
                numthree = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                double Mathtotal;
                double Mathaverage;
                double Mathsmallest;
                double Mathlargest;

                Mathtotal = Math.Round(numone + numtwo + numthree);
                Mathaverage = Math.Round(Mathtotal / 3);
                double[] Numbers = new[] { numone, numtwo, numthree };
                Mathsmallest = Numbers.Min();
                Mathlargest = Numbers.Max();

                Console.WriteLine($"Your total amount for the numbers provided is {Mathtotal}");
                Console.WriteLine($"The average amount is {Mathaverage}");
                Console.WriteLine($"The smallest is {Mathsmallest} ");
                Console.WriteLine($"The largest amount is {Mathlargest}");

                Console.WriteLine($"American Dollars: {Mathtotal.ToString("c", CultureInfo.CreateSpecificCulture("en-us"))}");
                Console.WriteLine($"Yen: {Mathtotal.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP"))}");
                Console.WriteLine($"Krona: {Mathtotal.ToString("c", CultureInfo.CreateSpecificCulture("sv-SE"))}");
                Console.WriteLine($"Baht: {Mathtotal.ToString("c", CultureInfo.CreateSpecificCulture("th-TH"))}");

                Console.WriteLine("Would you like to try a different amounts? y or n");
                repeat = Console.ReadLine().ToLower();
                if (repeat == "y")
                {
                    money = true;
                }
                else if (repeat == "n")
                {
                    Console.WriteLine("Thank you for trying my calculator!");
                    Console.ReadLine();
                    money = false;

                }
            }
            while (money);
        }
    }
}
