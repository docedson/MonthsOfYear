using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsOfYear
{
    //Defining the enum, which is placed directly within the namespace
    public enum Months { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, Octobor = 10, November = 11, December = 12};

    class Program
    {
        static void Main(string[] args)
        {
            //Have the user input a number
            Console.WriteLine("Let's convert the number you input to the corresponding month in a year. Please inter a number between 1 and 12.");
            int monthNum = Convert.ToInt32(Console.ReadLine());//It reads the input, converts it to an int, and assigns it to "monthNum"

            if (monthNum > 0 && monthNum < 13)
            {
                Months month = (Months)monthNum;//(Months) = go to the enum, compare the input (monthNum), and grab that value. Then assign it to "month"
                Console.WriteLine("Your number of " + monthNum + " corresponds to the month of " + month);
            }
            else
            {
                Console.WriteLine("You didn't enter a number between 1 and 12");
            }
            Console.ReadKey();

        }
    }
}
