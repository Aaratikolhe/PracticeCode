using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCofee
{
    public class Q1Results
    {
        public static double serviceScore = 8.0;
        public static double ServiceScore
        {
            get;
            set; 
        } 

        public static double CoffeeScore { get; set; } = 8.5;

        public static double PriceScore { get; set; } = 6.0;

        public static double FoodScore { get; set; } = 7.5;

        public static double WouldRecommend { get; set; } = 6.5;

        public static string FavoriteProduct { get; set; } = "Cold Cofee";

        public static string LeastFavoriteProduct { get; set; } = "Smoothie";

        public static double NumberSurveyed { get; set; } = 500;

        public static double NumberResponded { get; set; } = 325;

        public static double NumberRewardsMembers { get; set; } = 130;


    }
}
