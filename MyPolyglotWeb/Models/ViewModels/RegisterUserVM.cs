using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class RegisterUserVM
    {
        [DisplayName("Электронный адрес")]
        [Required(ErrorMessage = "Вы забыли ввести электронный адрес!")]
        [EmailAddress(ErrorMessage = "Что-то не похоже не электронные адрес :(")]
        public string Email { get; set; }

        [DisplayName("Пароль")]
        [Required(ErrorMessage = "Вы забыли ввести пароль!")]
        [MinLength(4, ErrorMessage = "Пароль должен быть больше 4 символов.")]
        [MaxLength(10, ErrorMessage = "Пароль не должен превышать 10 символов.")]
        public string Password { get; set; }
    }
}
