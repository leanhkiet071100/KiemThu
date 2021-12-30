using System;

namespace TMDT_Eshop.Areas.Admin.Models
{
    public class Invoices
    {
        public int id { get; set; }
        public string code { get; set; }
        public int AccountId { get; set; }
        public Accounts Accounts { get; set; }
        public DateTime IssuedDate { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhone { get; set; }
        public int Total { get; set; }
        public bool Status { get; set; }
    }
}
