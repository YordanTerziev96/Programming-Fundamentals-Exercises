using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years;
            long days;
            long hours;
            long minutes;
            long seconds;
            long milliseconds;
            BigInteger microseconds;
            BigInteger nanoseconds;
            years = centuries * 100;
            days = (long)(years * 365.2422);
            hours = days * 24;
            minutes = hours * 60;
            seconds = minutes * 60;
            milliseconds = seconds * 1000;
            microseconds = milliseconds * 1000;
            nanoseconds = microseconds * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = " +
                "{7} microseconds = {8} nanoseconds",
                centuries, years,
                days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);


        }
    }
}
