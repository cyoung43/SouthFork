using SouthFork.DAL;
using SouthFork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SouthFork.Controllers
{
    public class HomeController : Controller
    {
        private SouthForkDBContext db = new SouthForkDBContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            string email = form["Email address"].ToString();
            string password = form["Password"].ToString();

            var currentUser = db.Database.SqlQuery<Employee>(
                "SELECT * " +
                "FROM Employee " +
                "WHERE Email = '" + email + "' AND " +
                "Password = '" + password + "'");

            //string name = db.Database.SqlQuery<Employee>(
            //    "SELECT FirstName " +
            //    "FROM Employee " +
            //    "WHERE Email '" + email + "'"
            //    );

            if (currentUser.Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("Directory", "Home", new { userLogin = email });

            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult Directory(string userLogin)
        {
            ViewBag.user = userLogin;
            return View();
        }
    }
}