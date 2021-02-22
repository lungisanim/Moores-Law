using Moores_Law.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Moores_Law.Models
{
    class TagsModel
    {
        public DateTime TS { get; set; }
        public double Tag1 { get; set; }
        public double Tag2 { get; set; }

        public double Tag3 { get; set; }

        public double Tag4 { get; set; }

        public double Tag5 { get; set; }

        public double Tag6 { get; set; }

        public double Tag7 { get; set; }

        public double Tag8 { get; set; }

        public double Tag9 { get; set; }

        public double Tag10 { get; set; }

        public double Tag11 { get; set; }

        public double Tag12 { get; set; }

        public double Tag13 { get; set; }

        public double Tag14 { get; set; }

        public double Tag15 { get; set; }

        public double Tag16 { get; set; }

        public double Tag17 { get; set; }

        public double Tag18 { get; set; }

        //Sort the values given the column name(Tag)
        //public List<double> TagList = 
        //Calculate Standard deviation for a given column name(Tag)
        //Calculate RMS over a given column, with an adjustable window.
        //Detect a specific rate of change over a given column.
        public static double[] SortedTag(TagsModel tag)
        {
            List<double> list = new List<double>();
            foreach (var item in tag.ToString())
            {
                list.Add(item);
            }

            return list.ToArray();
        }
        public static double GetStandardDeviation(double[] tag)
        {
            List<double> tagList = tag.OfType<double>().ToList();
            double average = tagList.Average();
            double sum = tagList.Sum(x => (x - average) * (x - average));
            double denominator = tagList.Count - 1;

            return denominator > 0.0 ? Math.Sqrt(sum / denominator) : -1;
        }

        /* Assumptions:
         * Rate of Change is statistically (Change if X/ Change in Time)
         * So for this calculation: Sorted Array (Last x - First x / array.length)
         */
        public static double GetRateOfChange(double[] tag)
        {
            int length = tag.Length;

            if (length == 0)
                return 0.00;

            return (tag[length - 1] - tag[0]) / length;
        }

        public static double GetRootMeanSquare(double[] tag)
        {
            int square = 0, length = tag.Length;

            for (int i = 0; i < length; i++)
            {
                square += (int) Math.Pow(tag[i], 2);
            }

            float mean = (square / (float) length);
            float root = (float)Math.Sqrt(mean);

            return root;
        }
        public static List<TagsModel> ProcessFile(string file)
        {
            List<TagsModel> tags = File.ReadAllLines(file).Skip(1)
                          .Select(x => x.Split(','))
                          .Select(x => new TagsModel
                          {
                              TS = Parse.GetDate(x[0]),
                              Tag1 = Parse.GetDouble(x[1]),
                              Tag2 = Parse.GetDouble(x[2]),
                              Tag3 = Parse.GetDouble(x[3]),
                              Tag4 = Parse.GetDouble(x[4]),
                              Tag5 = Parse.GetDouble(x[5]),
                              Tag6 = Parse.GetDouble(x[6]),
                              Tag7 = Parse.GetDouble(x[7]),
                              Tag8 = Parse.GetDouble(x[8]),
                              Tag9 = Parse.GetDouble(x[9]),
                              Tag10 = Parse.GetDouble(x[10]),
                              Tag11 = Parse.GetDouble(x[11]),
                              Tag12 = Parse.GetDouble(x[12]),
                              Tag13 = Parse.GetDouble(x[13]),
                              Tag14 = Parse.GetDouble(x[14]),
                              Tag15 = Parse.GetDouble(x[15]),
                              Tag16 = Parse.GetDouble(x[16]),
                              Tag17 = Parse.GetDouble(x[17]),
                              Tag18 = Parse.GetDouble(x[18]),
                          }).ToList<TagsModel>();

            return tags;
        }
    }
}
