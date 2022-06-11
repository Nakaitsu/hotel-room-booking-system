using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Nome de usuário inválido, campo username não pode conter caracteres especiais ou espaço.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Informe um email válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe uma senha válida")]
        [MinLength(8, ErrorMessage = "A senha deve conter no mínimo 8 dígitos alfanúmericos")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "As senhas não podem ser diferentes!")]
        public string PasswordConfirm { get; set; }
    }

    public class SignInViewModel
    {
      [Required]
      public string Username { get; set; }
      [Required]
      public string Password { get; set; }
    }

    public class ProfileViewModel
    {
      // nao implementado
    }
}