using Microsoft.AspNetCore.Mvc;
using portfolio005.Data;
using portfolio005.ViewModel;
using System.Runtime.CompilerServices;

namespace portfolio005.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db;
        public HomeController(AppDbContext _db)
        {
                db= _db;
        }
        public IActionResult Index()
        {
            IndexVM ivm = new();
            ivm.about = db.tbl_About.FirstOrDefault();
            ivm.education = db.tbl_Education.ToList();
            ivm.facts = db.tbl_Facts.FirstOrDefault();
            ivm.service =db.tbl_Service.ToList();
            ivm.skill=db.tbl_Skill.ToList();
            ivm.social=db.tbl_Social.FirstOrDefault();
            ivm.testimonial=db.tbl_Testimonial.ToList();

            return View(ivm);
        }
    }
}
