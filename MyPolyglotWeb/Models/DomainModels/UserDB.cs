namespace MyPolyglotWeb.Models.DomainModels
{
    public class UserDB : BaseDB
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual UserRole Role { get; set; }
    }

    public enum UserRole
    {
        User = 0,
        Admin = 1,
    }
}
