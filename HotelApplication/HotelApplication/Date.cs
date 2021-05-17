using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    class Date
    {
        public static DateTime SetArrivalDate()
        {
            DateTime arrival = DateTime.Now;
            bool alive = true;
            while (alive)
            {
                try
                {
                    arrival = InputDate(); // set a date form console
                    if (arrival <= DateTime.Today.AddHours(12)) // arrival date cannot be less then date today
                        throw new Exception("Wrong arrival date");
                    alive = false;
                }
                catch (Exception exc)
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exc.Message);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Try again");
                    Console.ForegroundColor = color;
                }
            }
            return arrival;
        }
        public static DateTime SetDepartureDate(DateTime arrival)
        {
            DateTime departure = DateTime.Now;
            bool alive = true;
            while (alive)
            {
                try
                {
                    departure = InputDate(); // set a date form console
                    if (departure <= arrival) // departure date cannot be less then arrival date
                        throw new Exception("Wrong departure date");
                    alive = false;
                }
                catch (Exception exc)
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exc.Message);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Try again");
                    Console.ForegroundColor = color;
                }
            }
            return departure;
        }
        public static DateTime InputDate() // set a date form console
        {
            int[] Date = new int[3];
            Date[0] = Convert.ToInt32(Console.ReadLine());
            Date[1] = Convert.ToInt32(Console.ReadLine());
            Date[2] = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(Date[2], Date[1], Date[0]);

            return date.AddHours(12);
        }
    }
}
