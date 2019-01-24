using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeerorBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: 首页
        public ActionResult CodeerorIndex()
        {
            return View();
        }
    }
}