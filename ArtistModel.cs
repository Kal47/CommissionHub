using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommissionHub
{
    public class ArtistModel : UserModel
    {
        public int ArtistID { get; }
        public string ArtistPageName { get; set; }
        public List<string> ImageURLs { get; set; }
        public List<OpenCommisionsModel> OpenCommisions { get; set; }
        public List<RatingsModel> Ratings { get; set; }
    }
}
