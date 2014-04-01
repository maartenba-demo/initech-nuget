using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniTech.Framework.Formatting
{
    public static class DateFormatter
    {
        public static string Format(DateTime value)
        {
            return value.ToShortDateString();
        }
    }
}
