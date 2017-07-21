using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string[] dateNumbers = date.Split('-');
            int day = int.Parse(dateNumbers[0]);
            int month = int.Parse(dateNumbers[1]);
            int year = int.Parse(dateNumbers[2]);

            DateTime newDate = new DateTime(year, month, day);

            Console.WriteLine(newDate.DayOfWeek);

            /*
             string date = Console.ReadLine();
             DateTime dateToPrint = DateTime.ParseExact(date, "d-MM-yyyy, CultureInfo.InvariantCultureInfo");
             Console.WriteLine(dateToPrint.DayOfWeek);
             */
        }
    }
}
