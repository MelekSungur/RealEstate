using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RealEstate.PresentationLayer.Models;

namespace RealEstate.PresentationLayer.Models
{
    public class UserRegisterViewModel 
    {
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string name { get; set; }
        [Required(ErrorMessage = "Soyadı alanı boş geçilemez")]
        public string surname { get; set; }
        [Required(ErrorMessage = " Kullanıcı adı boş geçilemez")]
        public string username { get; set; }
        [Required(ErrorMessage = " Mail adı boş geçilemez")]
        public string mail { get; set; }
        [Required(ErrorMessage = " Şifre adı boş geçilemez")]
        public string password { get; set; }

        [Required(ErrorMessage = " Şifre Tekrar  alanı boş geçilemez")]
        [Compare("password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string confirmpassword { get; set; }
    }
}
