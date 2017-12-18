using MvcLoginReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLoginReg.Repositories;
namespace MvcLoginReg.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return View(db.userAccount.ToList());
            }
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Messag = account.FirstName + " " + account.Lastname + " Successfully registered";
            }
            return View();
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var usr = db.userAccount.Single(u => u.Username == user.Username && u.Password == u.Password);
                if (usr != null)

                {
                    var User = usr.UserID;
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.Username.ToString();
                    Session["FirstName"] = usr.FirstName.ToString();
                    Session["LastName"] = usr.Lastname.ToString();
                    Session["Born"] = usr.Born.ToString();
                    Session["Gender"] = usr.Gender.ToString();
                    Session["Looking"] = usr.Looking.ToString();

                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong.");

                }
            }
            return View();
        }
        public UserAccount GetUserAccount(UserAccount user)
        {
            MyDbContext db = new MyDbContext();

            var usr = db.userAccount.Single(u => u.Username == user.Username && u.Password == u.Password);

            return usr;
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult MyProfile()
        {
            
                return View(10);
            }
        
        
        //public ActionResult MyProfile(UserAccount user)
        //{
        //    using (MyDbContext db = new MyDbContext())
        //    {
        //        var usr = db.userAccount.Single(u => u.Username == user.Username && u.Password == u.Password);
        //        if (usr != null)
        //        {
        //            Session["UserID"] = usr.UserID.ToString();
        //            Session["Username"] = usr.Username.ToString();
        //            Session["FirstName"] = usr.FirstName.ToString();
        //            Session["LastName"] = usr.Lastname.ToString();
        //            Session["Born"] = usr.Born.ToString();
        //            Session["Gender"] = usr.Gender.ToString();
        //            Session["Looking"] = usr.Looking.ToString();
        //            return View();

        //        }
        //        else { 
        //            return RedirectToAction("LoggedIn");
        //        }
        //    }
            
        //}
    }
}