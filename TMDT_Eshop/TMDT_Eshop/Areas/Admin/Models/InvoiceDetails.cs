namespace TMDT_Eshop.Areas.Admin.Models
{
    public class InvoiceDetails
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public Invoices Invoices { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public int QuantityId { get; set; }
        public int UnitPrice { get; set; }
    }
}
