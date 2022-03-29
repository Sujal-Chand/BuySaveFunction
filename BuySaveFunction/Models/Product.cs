using System;
using System.Collections.Generic;

namespace BuySaveFunction.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Review> Review { get; set; }
    }
}
