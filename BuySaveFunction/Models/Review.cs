namespace BuySaveFunction.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public string ReviewText { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
