using Moores_Law.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Moores_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TagsModel> tags = TagsModel.ProcessFile("c:\\TestFile.csv");

            /*var tag1 = tags.Select(x => x.Tag1).OrderBy(x => x).ToArray();
            double sortTag = TagsModel.SortTag();
            double tag1stddev = TagsModel.GetStandardDeviation(sortTag);
            double tag1rms = TagsModel.GetRootMeanSquare(sortTag); 
            double tag1rateofchange = TagsModel.GetRateOfChange(sortTag);*/

            //Console.WriteLine("{0} {1} {2}", tag1stddev, tag1rms, tag1rateofchange);

            //var sortedTags = tags.Select(x => x).OrderBy(x => x);
            foreach (var tag in tags)
            {
                var sortedTag = TagsModel.SortedTag(tag);

                //double tag1stddev = TagsModel.GetStandardDeviation(tagArray);
                //double tag1rms = TagsModel.GetRootMeanSquare(tagArray);
                //double tag1rateofchange = TagsModel.GetRateOfChange(tagArray);
            }



        }
    }
}
