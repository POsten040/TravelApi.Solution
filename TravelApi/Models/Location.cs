using System.Collections.Generic;

namespace TravelApi.Models
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
    }
}