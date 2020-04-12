using Ajaxproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajaxproject.Controllers
{
    public class HomeController : Controller
    {
        static List<DEPTDATA> L = null;
        static List<EMPDATA> E = null;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Second()
        {
            return View();
        }
        public ActionResult Third()
        {
            return View();
        }
        public ActionResult Fourth()
        {
            return View();
        }
        public ActionResult Fifth()
        {
            return View();
        }
        public ActionResult GetDepts()
        {
            return View();
        }
        public ActionResult GetDeptNo()
        {
            //List<int> L = new List<int>();
            //L.Add(10);
            //L.Add(20);
            //L.Add(30);
            L = DBOperations.GetDept();
            return Json(L, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetEmpData(int deptno)
        {
            E = DBOperations.GetEmps(deptno);
            return Json(E, JsonRequestBehavior.AllowGet);
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