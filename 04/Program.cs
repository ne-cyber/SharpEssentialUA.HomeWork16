using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        class Date
        {
            private DateTime _date;
            public override string ToString()
            {
                return _date.ToString("dd.MM.yyyy");
            }
            public Date(int d, int m, int y)
            {
                _date = new DateTime(y, m, d);
            }

            public static int operator -(Date d1, Date d2)
            {
                TimeSpan span = d1._date - d2._date;
                return (int)span.TotalDays;
            }

            public static Date operator +(Date d, int a)
            {
                DateTime other = d._date;
                other = other.AddDays(a);
                return new Date(other.Day, other.Month, other.Year);
            }
        }

        static void Main(string[] args)
        {
            Date date = new Date(31, 12, 2024);
            Date date1 = new Date(27, 08, 2024);

            Console.WriteLine(date);
            Console.WriteLine(date1);

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("{0} - {1} = {2}", date, date1, date - date1);

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("{0} + 126 = {1}", date1, date1 + 126);

            Console.ReadKey();
        }
    }
}
