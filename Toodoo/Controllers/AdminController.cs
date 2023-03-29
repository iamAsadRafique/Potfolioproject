using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using portfolio005.Data;
using portfolio005.Models;
using portfolio005.ViewModel;

namespace portfolio005.Controllers
{
    public class AdminController : Controller
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public AdminController(AppDbContext _db, IWebHostEnvironment _env)
        {
            this.db = _db;
            this.env = _env;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Username"] = HttpContext.Session.GetString("Username");
                return View();
            }

            return RedirectToAction(nameof(Login));
        }
        # region About
        public IActionResult About()
        {

            if (HttpContext.Session.GetString("flage") == "true")
            {
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Username"] = HttpContext.Session.GetString("Username");
                return View();
            }

            return RedirectToAction(nameof(Login));
        }
        public IActionResult ShowAbout()
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var myprofile = db.tbl_About.Where(x => x.UserName == HttpContext.Session.GetString("Username")).FirstOrDefault();
                return View(myprofile);
            }
            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        public IActionResult About(AboutVM aboutvm)
        {
            string ImageName = aboutvm.Image.FileName.ToString();
            About about = new About();


            about.Name = aboutvm.Name;
            about.Degree = aboutvm.Degree;
            about.Age = aboutvm.Age;
            about.Degree = about.Degree;
            about.DoB = aboutvm.DoB;
            about.Email = aboutvm.Email;
            about.city = aboutvm.city;
            about.Description = aboutvm.Description;
            about.phone = aboutvm.phone;
            about.freelance = aboutvm.freelance;
            about.Image = ImageName;
            about.Website = aboutvm.Website;

            var Folderpath = Path.Combine(env.WebRootPath, "Images");
            var Imagepath = Path.Combine(Folderpath, ImageName);
            aboutvm.Image.CopyTo(new FileStream(Imagepath, FileMode.Create));

            db.tbl_About.Add(about);
            db.SaveChanges();
            return View();
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            return View();
        }
        public IActionResult DeleteAbout(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var finddel = db.tbl_About.Find(id);
                db.tbl_About.Remove(finddel);
                db.SaveChanges();
                return RedirectToAction(nameof(ShowAbout));
            }
            return RedirectToAction(nameof(Login));
        }

        #endregion
        #region Education
        public IActionResult Education()
        {

            if (HttpContext.Session.GetString("flage") == "true")
            {
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Username"] = HttpContext.Session.GetString("Username");
                return View();
            }

            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        public IActionResult Eduction(Education education)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Education.Add(education);
                db.SaveChanges();
                return RedirectToAction(nameof(ShowEducation));

            }
            return View();

        }
        public IActionResult ShowEducation()
        {
            if (HttpContext.Session.GetString("flage") == "true")

            {
                var ShowEducation = db.tbl_Education;
                return View(ShowEducation);
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult UpdateEducation(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var EducationDetail = db.tbl_Education.Find(id);
                return View(EducationDetail);
            }
            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            db.tbl_Education.Update(education);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowEducation));
        }
        public IActionResult DeleteEducation(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var findtodel = db.tbl_Education.Find(id);
                db.tbl_Education.Remove(findtodel);
                db.SaveChanges();
                return RedirectToAction(nameof(ShowEducation));
            }
            return RedirectToAction(nameof(Login));
        }
        #endregion
        #region Fact
        public IActionResult Fact()
        {

            if (HttpContext.Session.GetString("flage") == "true")
            {
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Username"] = HttpContext.Session.GetString("Username");
                return View();
            }

            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        public IActionResult Fact(Facts fact)
        {
            db.tbl_Facts.Add(fact);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowFact));
        }
        public IActionResult ShowFact()
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var allfact = db.tbl_Facts;
                return View(allfact);
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult UpdateFact(int id)
        {
            var updatedata = db.tbl_Facts.Find(id);
            return View(updatedata);
        }
        [HttpPost]
        public IActionResult UpdateFact(Facts fact)
        {
            db.tbl_Facts.Update(fact);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowFact));
        }
        public IActionResult DeleteFact(int id)
        {
            var delFact = db.tbl_Facts.Find(id);
            db.tbl_Facts.Remove(delFact);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowFact));
        }

        #endregion
        #region Services

        public IActionResult Services()
        {

            if (HttpContext.Session.GetString("flage") == "true")
            {
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Username"] = HttpContext.Session.GetString("Username");
                return View();
            }

            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        public IActionResult Service(Service services)
        {
            db.tbl_Service.Add(services);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowServices));
        }
        public IActionResult DeleteServices(int id)
        {
            var deltoitem = db.tbl_Service.Find(id);
            db.tbl_Service.Remove(deltoitem);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowServices));
        }
        public IActionResult ShowServices()
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var showservice = db.tbl_Service;
                return View(showservice);
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult UpdateServices(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var updatetoitem = db.tbl_Service.Find(id);
                return View(updatetoitem);
            }

            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        public IActionResult updateservices(Service service)
        {
            db.tbl_Service.Update(service);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowServices));
        }

        #endregion
        #region Skill

        public IActionResult Skill()
        {

            if (HttpContext.Session.GetString("flage") == "true")
            {
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Username"] = HttpContext.Session.GetString("Username");
                return View();
            }

            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        public IActionResult Skill(Skill skill)
        {
            db.tbl_Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowSkill));
        }
        public IActionResult ShowSkill()
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var Showtoskil = db.tbl_Skill;
                return View(Showtoskil);
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult UpdateSkill(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var updateSkill = db.tbl_Skill.Find(id);
                return View(updateSkill);
            }
            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            db.tbl_Skill.Update(skill);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowSkill));
        }

        public IActionResult DeleteSkill(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var delSkill = db.tbl_Skill.Find(id);
                db.tbl_Skill.Remove(delSkill);
                db.SaveChanges();
                return RedirectToAction(nameof(ShowSkill));
            }
            return RedirectToAction(nameof(Login));
        }
        #endregion
        #region Social

        public IActionResult Social()
        {

            if (HttpContext.Session.GetString("flage") == "true")
            {
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Username"] = HttpContext.Session.GetString("Username");
                return View();
            }

            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        public IActionResult Social(Social social)
        {
            db.tbl_Social.Add(social);
            db.SaveChanges();
            return RedirectToAction(nameof(ShowSocial));
        }
        public IActionResult ShowSocial()
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var allSocial = db.tbl_Social;
                return View(allSocial);
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult UpdateSocial(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var updatesocial = db.tbl_Social.Find(id);
                return View(updatesocial);
            }
            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        public IActionResult UpdateSocial(Social social)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                db.tbl_Social.Update(social);
                db.SaveChanges();
                return RedirectToAction(nameof(ShowSocial));
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult DeleteSocial(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var delsocial = db.tbl_Social.Find(id);
                db.tbl_Social.Remove(delsocial);
                db.SaveChanges();
                return RedirectToAction(nameof(ShowSocial));
            }
            return RedirectToAction(nameof(Login));
        }
        #endregion
        #region Testimonail

        public IActionResult Testimonail()

        {

            if (HttpContext.Session.GetString("flage") == "true")
            {
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Username"] = HttpContext.Session.GetString("Username");
                return View();
            }

            return RedirectToAction(nameof(Login));


        }
        [HttpPost]
        public IActionResult Testimonail(TestimonialVM tvm)

        {
            string ImageName = tvm.Image.FileName.ToString();
            Testimonial t = new Testimonial();
            t.Name = tvm.Name;
            t.Designation = tvm.Designation;
            t.Review = tvm.Review;
            t.Image = ImageName;
            var Folderpath = Path.Combine(env.WebRootPath, "Images");
            var Picturepath = Path.Combine(Folderpath, ImageName);
            tvm.Image.CopyTo(new FileStream(Picturepath, FileMode.Create));
            db.tbl_Testimonial.Add(t);
            db.SaveChanges();
            return View();

        }
        public IActionResult ShowTestimonial()
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var stestmonial = db.tbl_Testimonial;
                return View(stestmonial);
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult UpdateTestimonial(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var TestimonialDetail = db.tbl_Testimonial.Find(id);
                return View(TestimonialDetail);
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult DeleteTestimonial(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var finddel = db.tbl_Testimonial.Find(id);
                db.tbl_Testimonial.Remove(finddel);
                db.SaveChanges();
                return RedirectToAction(nameof(ShowTestimonial));
            }
            return RedirectToAction(nameof(Login));
        }
            #endregion
        #region Login
            public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM loginVM)

        {
            if (ModelState.IsValid)
            {

                var User = db.tbl_About.Where(A => A.UserName == loginVM.UserName && A.PassWord == loginVM.Password).FirstOrDefault();
                if (User is not null)
                {
                    HttpContext.Session.SetString("flage", "true");
                    HttpContext.Session.SetString("username", User.UserName);
                    HttpContext.Session.SetString("image", User.Image);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewData["LoginError"] = "Invalid Username or password";
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }



        #endregion
        #region Contact
        [HttpPost]
        public IActionResult Message(string name, string email, string subject, string message)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                Contact contact = new Contact();
                contact.Name = name;
                contact.Email = email;
                contact.Subject = subject;
                contact.Message = message;
                db.tbl_Contact.Add(contact);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction(nameof(Login));

        }
        public IActionResult ShowMessage()
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var AllMessages = db.tbl_Contact;
                return View(AllMessages);
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult DeleteMessages(int id)
        {
            if (HttpContext.Session.GetString("flage") == "true")
            {
                var ItemToDel = db.tbl_Contact.Find(id);
                if (ItemToDel != null)
                {
                    db.tbl_Contact.Remove(ItemToDel);
                }
                return RedirectToAction(nameof(ShowMessage));

            }
            return RedirectToAction(nameof(Login));
        }
    }
}

#endregion




