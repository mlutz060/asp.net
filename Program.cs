using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.Write("What is your name: ");
            var name = Console.ReadLine();

            //2.
            Console.Write("Enter Location: ");
            string location = Console.ReadLine();

            //3.
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You are in " + location);

            //4.
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is {currentDate:D}");

            //5.
            var christmas = new DateTime(currentDate.Year, 12, 25);
            var daysUntilChristmas = christmas - currentDate;
            Console.WriteLine($"There are {daysUntilChristmas.Days} days until Christmas.");

            //6.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("What is the width of the string? ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("What is the height of the string? ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * ( width + height ) * 3.25 ;
            glassArea = 2 * ( width * height ) ;
            Console.WriteLine ( "The length of the wood is " + woodLength + " feet" ) ;
            Console.WriteLine( "The area of the glass is " + glassArea + " square metres" ) ;

            //7.
            Console.Write("Press any key to quit");
            Console.ReadKey();

        }
    }
}
