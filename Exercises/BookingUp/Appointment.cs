using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.BookingUp
{
    internal class Appointment
    {
        public Appointment()
        {

        }
        public static DateTime Schedule(string informedDate)
        {
            string[] parts = informedDate.Split('/', ':', ' ');
            int year = int.Parse(parts[2]);
            int month = int.Parse(parts[0]);
            int day = int.Parse(parts[1]);
            int hour = int.Parse(parts[3]);
            int minute = int.Parse(parts[4]);
            int second = int.Parse(parts[5]);

            DateTime date = new DateTime(year, month, day, hour, minute, second);

            return date;
        }

        public static bool HasPassed(DateTime date)
        {
            if (date<=DateTime.Now) return true ;
            else return false ;

        }

        public static bool IsAfternoonAppointment(DateTime date)
        {
            if (date.Hour>=12 && date.Hour<18) return true;
            else return false ;
        }
    }
}
