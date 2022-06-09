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

        public static double CoffeeScore { get; set; } = 4.5;

        public static double PriceScore { get; set; } = 6.0;

        public static double FoodScore { get; set; } = 7.5;

        public static double WouldRecommend { get; set; } = 6.5;

        public static string FavoriteProduct { get; set; } = "Cold Cofee";

        public static string LeastFavoriteProduct { get; set; } = "Smoothie";

        public static string AreaToImprove { get; set; } = "Hours of operation";

        public static double NumberSurveyed { get; set; } = 500;

        public static double NumberResponded { get; set; } = 325;

        public static double NumberRewardsMembers { get; set; } = 130;

        public static List<SurveyResponse> Responses = new List<SurveyResponse>()
        {
            new SurveyResponse()
            {
                EmailAddress = "test1@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 9.0,
                PriceScore = 7.0,
                ServiceScore = 8.5,
                AreaToImprove = "Hours of operation",
                FavoriteProduct = "Latte",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Your mobile app is too slow."
            },
            new SurveyResponse()
            {
                EmailAddress = "test2@sample.com",
                CoffeeScore = 10.0,
                FoodScore = 6.0,
                PriceScore = 7.0,
                ServiceScore = 7.5,
                AreaToImprove = "MobileApp",
                FavoriteProduct = "Cold Cofee",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "The mobile app looks bad on Android devices."
            },
            new SurveyResponse()
            {
                EmailAddress = "test3@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 7.0,
                PriceScore = 6.5,
                ServiceScore = 8.5,
                AreaToImprove = "Cleanliness",
                FavoriteProduct = "Americano",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Overall I had a great experience, I like the store design."
            },
            new SurveyResponse()
            {
                EmailAddress = "test4@sample.com",
                CoffeeScore = 9.0,
                FoodScore = 5.0,
                PriceScore = 7.5,
                ServiceScore = 8.5,
                AreaToImprove = "Pricing",
                FavoriteProduct = "Cold Cofee",
                LeastFavoriteProduct = "Fruit",
                WouldRecommend = 4.0,
                Comments = "The pickup area should be by the door. Also Your prices are much higher than the surrounding stores."
            }
        };

    }
}
