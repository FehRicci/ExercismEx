using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Gigasecond
{
    internal static class Gigasecond
    {
        public static DateTime Add(DateTime moment)
        {
            return moment.AddSeconds(1000000000);
        }
    }
}
