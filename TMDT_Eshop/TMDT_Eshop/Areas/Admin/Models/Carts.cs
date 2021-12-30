namespace TMDT_Eshop.Areas.Admin.Models
{
    public class Carts
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Accounts Accounts { get; set; }
        public int ProducId { get; set; }
        public Products Products { get; set; }
        public int Quantity { get; set; }
    }
}
