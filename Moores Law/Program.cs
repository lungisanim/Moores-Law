using Moores_Law.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static Moores_Law.Utilities.Enums;

namespace Moores_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TagsModel> tags = TagsModel.ProcessFile("c:\\TestFile.csv");
            string outputFile = "C:\\OutputTestFile.csv";

            var tagEnums = Enum.GetValues(typeof(Tagging)).Cast<Tagging>().Select(x => x.ToString()).ToList();
            foreach (var item in tagEnums)
            {
                var sortedTags = tags.Select(x => x.item).OrderBy(x => x).ToArray();
                var csv = new StringBuilder();
                foreach (var tag in sortedTags)
                {
                    var sortedTag = TagsModel.SortedTag(tag);
                    string Id = item;
                    DateTime now = DateTime.Now;
                    double tagstddev = TagsModel.GetStandardDeviation(sortedTag);
                    double tagrms = TagsModel.GetRootMeanSquare(sortedTag);
                    double tagrateofchange = TagsModel.GetRateOfChange(sortedTag);

                    var newline = string.Format("{0}, {1}, {2}, {3}, {4}", Id, now, tagstddev, tagrms, tagrateofchange);
                    csv.AppendLine(newline);
                }

                File.WriteAllText(outputFile, csv.ToString());
            }



        }
    }
}
