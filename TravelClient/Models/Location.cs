using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient
{
    public class Location
    {
      public Location()
      {
        this.JoinEntries = new HashSet<LocationReview>();
      }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }

        public ICollection<LocationReview> JoinEntries { get; }
        public static List<Location> GetLocations()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;
            JArray jsonResponse - JsonConvert.DeserializeObject<JArray>(result);
            List<Location> locationList = JsonConvert.DeserializeObject<List<Location>>(jsonResponse.ToString());
            
            return locationList;
        }
    }
}