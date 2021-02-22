using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moores_Law.Utilities
{
    class Calculations
    {
        public static List<double> SortTags(List<double> list)
        {
            if (list == null)
                return new List<double>();

            return (List<double>) list.OrderBy(x => x);
        }


    }
}
