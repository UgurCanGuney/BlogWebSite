using BlogWebSite.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            MakaleRepository rep = new MakaleRepository();
            List<Makale> m = rep.Listele();
            return View(m);
        }
    }
}