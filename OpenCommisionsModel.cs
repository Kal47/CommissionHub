using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommissionHub
{
    public class OpenCommisionsModel
    {
        public int CommissionId { get; }
        public string Title { get; set; }
        public string Body { get; set; }
        public List<string> Images { get; set; }
    }
}
