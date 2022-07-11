using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 using BasicLinQ.Models;



namespace BasicLinQ.Controllers

{
    
    public class HomeController : Controller
    {
        private EntityDBEntities1 _db = new EntityDBEntities1();
        public ActionResult Index()
            // LAY RA HOC SINH

        {
            var stu = (from s in _db.Students select s).ToList();
            ViewBag.Studens = stu;
            return View();


        }
        public ActionResult Delete(int id)
        {

            var e = _db.Students.FirstOrDefault(x => x.StudentID == id);
            _db.Students.DeleteonSubmit
            
                
                ViewBag.Message = "xóa thành công.";

                
         
            return View();
        }

        public ActionResult add(int id)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult About(int id)
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