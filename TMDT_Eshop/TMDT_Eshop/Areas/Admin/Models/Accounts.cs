namespace TMDT_Eshop.Areas.Admin.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public string Avatar { get; set; }
        public bool Status { get; set; }

    }
}
