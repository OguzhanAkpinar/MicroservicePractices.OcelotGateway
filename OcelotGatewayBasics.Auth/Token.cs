namespace ECommerceBase.Auth
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class AuthToken
    {
        public string AccessToken { get; set; }
        public double Expires { get; set; }
    }
}
