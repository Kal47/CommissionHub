using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommissionHub
{
    public class RatingsModel
    {
        public int RatingId { get; }//not null
        public int RatingStarsPunctual { get; set; }
        public int RatingStarstProfesinal { get; set; }
        public int RatingStarsCommunication { get; set; }
    }

    
}
