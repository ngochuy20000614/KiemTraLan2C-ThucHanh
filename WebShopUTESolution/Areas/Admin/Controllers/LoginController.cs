using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShopUTESolution.Areas.Admin.Models;

namespace WebShopUTESolution.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class LoginController : Controller
    {
        
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.login(user.Username, user.Password);
                if(result == 1)
                {
                    ModelState.AddModelError("", "Đăng nhập thành công");
                    RedirectToAction("Home", "Index");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không thành công");
                    
                }
            }
            return View("Index");
        }
    }
}