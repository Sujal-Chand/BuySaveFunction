using System;
using System.Collections.Generic;

namespace BuySaveFunction.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public int Reviews { get; set; }
        public DateTime JoinDate { get; set; }

        public ICollection<Review> Review { get; set; }
    }
}
