using KmrApiTestServ.Attributes;
using KmrApiTestServ.Data;
using KmrApiTestServ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KmrApiTestServ.Controllers
{
    [RoutePrefix("user")]
    public class UserController : Controller
    {
        [Route("all")] // users/all
        [HttpGet]
        [AllowXSite]
        public ActionResult All()
        {
           return Json( new UserCollection(), JsonRequestBehavior.AllowGet);
        }

        [Route("{id}")] // users/1
        [HttpGet]
        [AllowXSite]
        public ActionResult View(int id)
        {
            var users = new UserCollection();
            return Json(users.Find(o => o.Id == id), JsonRequestBehavior.AllowGet);
        }

        [Route("login")] // users/1
        [HttpPost]
        [AllowXSite]
        public ActionResult Login(User u)
        {
            var users = new UserCollection();
            var user = users.Find(o => o.Username == u.Username && o.Password == u.Password);

            string r_message = "Login failed.";
            bool r_status = false;
            if (user!=null)
            {
                r_status = true;
                r_message = "Login successful.";
            }
           
            return Json(new
            {
                status = r_status,
                message = r_message
            }, JsonRequestBehavior.AllowGet);
        }


    }
}