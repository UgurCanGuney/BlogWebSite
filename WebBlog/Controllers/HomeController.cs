using BlogWebSite.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MakaleRepository rep = new MakaleRepository();
        public ActionResult Index()
        {
           
            return View(rep.Listele().OrderByDescending(z => z.Id));
        }
       

    }
}