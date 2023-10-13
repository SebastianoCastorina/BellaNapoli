using BellaNapoli.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace BellaNapoli.Controllers
{


    public class HomeController : Controller
    {
        private ModelDbContext db = new ModelDbContext();


        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(db.Prodotti.ToList());
        }
        public ActionResult Register()

        {

            return View();


        }

        [HttpPost]
        public ActionResult Register(User u)
        {
            u.Role = "user";
            db.User.Add(u);
            db.SaveChanges();
            return RedirectToAction("Login");





        }
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "Username, Password")] User u)
        {
            User user = db.User.Find(u.IdUser);
            if (user == null)
            {
                FormsAuthentication.SetAuthCookie(u.Username, false);
                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Remove("Carrello");
            return RedirectToAction("Index", "Home");
        }
        public ActionResult AddCarrello(int id)
        {
            Prodotti pincarrello = db.Prodotti.Find(id);

            List<Prodotti> Carrello = Session["Carrello"] as List<Prodotti> ?? new List<Prodotti>();
            Carrello.Add(pincarrello);
            Session["Carrello"] = Carrello;
            return RedirectToAction("index");
        }
    }

}
 
   
