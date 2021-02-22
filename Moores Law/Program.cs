using Moores_Law.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Moores_Law.Utilities.Enums;

namespace Moores_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TagsModel> tags = TagsModel.ProcessFile("c:\\TestFile.csv");

            var tagEnums = Enum.GetValues(typeof(Tagging)).Cast<Tagging>().Select(x => x.ToString()).ToList();
            foreach (var item in tagEnums)
            {
                var sortedTags = tags.Select(x => x.item).OrderBy(x => x).ToArray();
                foreach (var tag in sortedTags)
                {
                    var sortedTag = TagsModel.SortedTag(tag);

                    double tag1stddev = TagsModel.GetStandardDeviation(tagArray);
                    double tag1rms = TagsModel.GetRootMeanSquare(tagArray);
                    double tag1rateofchange = TagsModel.GetRateOfChange(tagArray);
                }
            }



        }
    }
}
