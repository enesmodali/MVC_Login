using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Login.Models.VM
{
    public class LoginVM
    {
        [
            EmailAddress(ErrorMessage ="E posta adresiniz doğru formatta değil."),
            Required(ErrorMessage ="E posta alanı girmek zorunludur."),
            DisplayName("E-posta")
        ]
        public string Email { get; set; }
        [
            Required(ErrorMessage = "Parola alanı girmek zorunludur."),
            DisplayName("Parola")
        ]
        public string Password { get; set; }
        [
           DisplayName("Beni Hatırla")
       ]
        public bool IsPersitant { get; set; } //Beni Hatırla
    }
}