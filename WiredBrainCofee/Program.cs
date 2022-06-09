using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCofee
{
    class Program
    {
        public static void Main(string[] args)
        {
            GenerateTasksReport();
            GenerateCommentsReport();
            var selectedEmails=new List<string>();
            int counter = 0;
            while(selectedEmails.Count<2&&counter<Q1Results.Responses.Count)
            {
                var currentItem = Q1Results.Responses[counter];
                if(currentItem.FavoriteProduct==Q1Results.FavoriteProduct)
                {
                    selectedEmails.Add(currentItem.FavoriteProduct);
                    Console.WriteLine(currentItem.EmailAddress);
                }
                counter++;
            }

        }

        private static void GenerateCommentsReport()
        {
            Console.WriteLine("Comments for resopnses having wouldRecommend>7");
            for (var i = 0; i < Q1Results.Responses.Count; i++)
            {
                var currentResponse = Q1Results.Responses[i];
                if (currentResponse.WouldRecommend > 7.0)
                {
                    Console.WriteLine(currentResponse.Comments);
                }
            }
            //foreach (var response in Q1Results.Responses)
            //{
            //    if (response.WouldRecommend > 7.0)
            //    {
            //        Console.WriteLine(response.Comments);
            //    }
            Console.WriteLine("Comments for responses having Area to improve same as initialized value");
            foreach (var response in Q1Results.Responses)
            {
                if (response.AreaToImprove == Q1Results.AreaToImprove)
                {
                    Console.WriteLine(response.Comments);
                }
            }
        }

        public static void GenerateTasksReport()
        {
            var tasks = new List<string>();
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            bool isCofeeScoreLower = Q1Results.CoffeeScore < Q1Results.FoodScore;
            if (isCofeeScoreLower)
            {
                tasks.Add("Investigate coffee recipe and ingredients");
            }
            if (overallScore > 8.0)
            {
                tasks.Add("Reward Staff");
            }
            else
            {
                tasks.Add("Work on improvement ideas");
            }
            if (responseRate < 0.33)
            {
                tasks.Add("Research to improve response");
            }
            else if (responseRate > 0.33 && responseRate < 0.66)
            {
                tasks.Add("Reward participants with free coffee coupon");
            }
            else
            {
                tasks.Add("Reward prticipants with discount coupon");
            }
            switch (Q1Results.AreaToImprove)
            {
                case "RewardsProgram":
                    tasks.Add("Revisit the reward deals");
                    break;
                case "Cleanliness":
                    tasks.Add("Contact cleaning vendors to Keep the area clean ");
                    break;
                case "Hours of Operation":
                    tasks.Add("Increase hours of operation");
                    break;
                default:
                    tasks.Add("Investigate comment for ideas");
                    break;
            }
        }
    }
}
