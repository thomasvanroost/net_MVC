using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using imdleaderboard.Models;

namespace imdleaderboard.Controllers
{
    public class SkillsController : Controller
    {
        //
        // GET: /Skills/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Grant()
        {
            //alle users doorgeven naar view door viewbag.
            UserModel usermodel = new UserModel();
            ViewBag.users = usermodel.selectAll(); 

            SkillModel skillmodel = new SkillModel();
            ViewBag.skills = skillmodel.selectAll();

            return View();
        }

    }
}
