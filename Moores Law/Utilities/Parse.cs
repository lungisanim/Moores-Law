using System;
using System.Collections.Generic;
using System.Text;

namespace Moores_Law.Utilities
{
    class Parse
    {
        public static DateTime GetDate(string strDate)
        {
            if (strDate == null)
                return DateTime.Now;

            return DateTime.Parse(strDate, System.Globalization.CultureInfo.InvariantCulture);
        }

        public static double GetDouble(string number)
        {
            if (number == null)
                return 0;

            return Double.Parse(number, System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
