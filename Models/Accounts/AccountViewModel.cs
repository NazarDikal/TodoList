using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models.Accounts
{
    public class AccountViewModel 
    {
        public LoginViewModel LoginViewModel { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage ="Обов'язкове поле")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Password { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        public string RepeatPassword { get; set; }
    }
}
