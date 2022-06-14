using System.ComponentModel.DataAnnotations;

namespace Blog.Models.ViewModels.Accounts
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string Password { get; set; }

        

    }
}