using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace TravelClient.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Body { get; set; }
        public string UserName { get; set; }
        // public int LocationId { get; set; }
        // public virtual Location Location { get; set; }
        public static List<Review> GetReviews()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

            return reviewList;
        }
    }
    
}