using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace WebBlog.Models
{
    public class FormModel
    {
        [Required(ErrorMessage ="Adınızı ve Soyadınızı giriniz.")]
        public string AdSoyad { get; set; }
        [Required(ErrorMessage = "Email adresinizini giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mesaj giriniz.")]
        public string Mesaj { get; set; }
        
    }
}