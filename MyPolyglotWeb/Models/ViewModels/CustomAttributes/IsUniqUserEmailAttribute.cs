using Microsoft.Extensions.DependencyInjection;
using MyPolyglotWeb.Repositories.IRepository;
using System.ComponentModel.DataAnnotations;

namespace MyPolyglotWeb.Models.ViewModels.CustomAttributes
{
    public class IsUniqUserEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var email = (string)value;
            var userRepository = validationContext.GetService<IUserRepository>();
            return userRepository.IsUserExist(email)
                ? new ValidationResult("Пользователь с таким электронным адресом уже существует.")
                : ValidationResult.Success;
        }
    }
}
