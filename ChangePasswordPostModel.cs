namespace B2BEcommerce.Models.Authentication
{
    public class ChangePasswordPostModel
    {
        public string EMAIL { get; set; }
        public string FIRMNR { get; set; }
        public string PASSWORD { get; set; }
        public string OLD_PASSWORD { get; set; }
    }
}
