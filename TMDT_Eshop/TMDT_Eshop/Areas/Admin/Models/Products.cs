namespace TMDT_Eshop.Areas.Admin.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; } = 0;
        public int Stock { get; set; }
        public int ProductTypeId { get; set; }
        ProductTypes ProductType { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
