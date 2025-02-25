using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lüften adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lüften soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lüften kullanıcı adınızı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lüften mail adresini giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lüften şifreyi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lüften şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage = "şifreler uyumlu degil")]
        public string ConfirmPassword { get; set; }
    }
}