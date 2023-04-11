using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Gigasecond
{
    internal static class Gigasecond
    {
        private static float _gigasecond = 1e9f;

        public static DateTime Add(DateTime moment) => moment.AddSeconds(_gigasecond);
    }
}
