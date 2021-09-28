using System.ComponentModel;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class LoginVM
    {
        [DisplayName("Электронный адрес")]
        public string Email { get; set; }

        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
