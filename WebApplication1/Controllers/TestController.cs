using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult TestView()
        {
            TestClass tc = new TestClass();
            tc.Id = Guid.NewGuid();
            tc.Name = "wooow";
            tc.IsTest = true;
            tc.Id = Guid.Empty;
            return View(tc);
        }
	}
}