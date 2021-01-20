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
        
        public static Location GetDetails(int id)
        {
        var apiCallTask = ApiHelper.Get(id);
        var result = apiCallTask.Result;

        JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
        Location location = JsonConvert.DeserializeObject<Location>(jsonResponse.ToString());

        return location;
        }
        public static void Post(Location location)
        {
        string jsonLocation = JsonConvert.SerializeObject(location);
        var apiCallTask = ApiHelper.Post(jsonLocation);
        }
    }
}