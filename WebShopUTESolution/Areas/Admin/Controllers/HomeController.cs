using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebShopUTESolution.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {

        //private readonly DbContextWebUTE _db;
        //public HomeController(DbContextWebUTE db)
        //{
        //    _db = db;
        //}
        // GET: Admin/Home
        StudentDataAccessLayer studentDataAccessLayer = null;
        public HomeController()
        {
            studentDataAccessLayer = new StudentDataAccessLayer();
        }

        //public ActionResult Index()
        //{

        //    IEnumerable<SinhVien> students = studentDataAccessLayer.GetAllStudent();
        //    return View(students);
        //}


        public ActionResult Index(string term)
        {
            IEnumerable<SinhVien> students = studentDataAccessLayer.GetSinhVienById(term);
            return View(students);
        }
    }
}