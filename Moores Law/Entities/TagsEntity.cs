using System;
//using System.Data.Entity;
using System.Collections.Generic;
using System.Text;

namespace Moores_Law.Entities
{
    class TagsEntity
    {
        public string ID { get; set; }
        public DateTime DateOfProcessing { get; set; }
        public double StandardDeviation { get; set; }
        public double RootMeanSquare { get; set; }
        public double RateOfChange { get; set; }

    }
}
