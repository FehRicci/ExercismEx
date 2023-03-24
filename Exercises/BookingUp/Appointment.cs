using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.BookingUp
{
    internal class Appointment
    {
        public static DateTime Schedule(string informedDate)
        {
            DateTime date = DateTime.Parse(informedDate);

            return date;
        }

        public static bool HasPassed(DateTime date)
        {
            if (date <= DateTime.Now) return true;
            else return false;
        }

        public static bool IsAfternoonAppointment(DateTime date)
        {
            if (date.Hour >= 12 && date.Hour < 18) return true;
            else return false;
        }

        public static string Description(DateTime date)
        {
            return "You have an appointment on " + date + ".";
        }

        public static DateTime AnniversaryDate()
        {
            return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
        }
    }
}
