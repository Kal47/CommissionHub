using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommissionHub
{
    public class UserModel
    {
        public int UserId { get;} //not null
        public string UserName { get; set; }//not null
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string PaymentInformation { get; set; }
        public int Artistid { get; }
    }
}
