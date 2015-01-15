using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model = MvcAreasApp.Areas.Blog.Models;

namespace MvcAreasApp.Areas.Blog.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/Blog/

        public ActionResult ShowRecent()
        {
            List<model.Blog> blogs = new List<model.Blog>
            { 
                new model.Blog
                {
                    Id=1,
                    Title="My first blog",
                    Post="Sample Blog"                    
                }
            };

            return View(blogs);
        }

    }
}
