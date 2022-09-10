using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MdReazulIslam_298652.Models;

namespace MdReazulIslam_298652.Controllers
{
    public class HomeController : Controller
    {
        MdReazulIslam_298652Entities db = new MdReazulIslam_298652Entities();
        public ActionResult Index()
        {
            var req = db.Requests.OrderByDescending(r => r.ReqID).ToList().Take(3);

            ViewBag.requests = req;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}