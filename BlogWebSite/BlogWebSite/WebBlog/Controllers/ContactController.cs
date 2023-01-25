using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebBlog.Models;

namespace WebBlog.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(FormModel model)
        {
            return RedirectToAction("Index");
        }
        public ActionResult MailSender(FormModel model)
        {
            ViewBag.msj = null;
            var fromAddress = new MailAddress("simurg.likit@gmail.com");
            var toAddress = new MailAddress("simurg.likit@gmail.com");
            string subject = $"{model.Email} Adresinden Gelen Mail";
            string from = model.Email;
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "115792Aa")
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = model.Mesaj })
                {
                    smtp.Send(message);
                    ViewBag.msj = "Mailiniz tarafıma ulaşmıştır.";
                }
            }
            return RedirectToAction("Index");
           
        }


    }
}