using SchoolEMS.Models;
using System;
using System.Web.Mvc;
using System.Web.Security;

namespace SchoolEMS.Controllers
{

    public class AccountController : Controller
    {
        readonly AdminDashEntities db = new AdminDashEntities();

        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "AdminRole")]
        [HttpGet]
        public ActionResult AdminRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminRegister(Admin admin)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Membership.CreateUser(admin.email, admin.password);
                    Roles.AddUserToRole(admin.email, "AdminRole");

                    db.Admin.Add(admin);
                    db.SaveChanges();
                    return RedirectToAction("AdminRegister");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            admin.confirmPassword = admin.password;
            if (ModelState.ContainsKey("confirmPassword"))
                ModelState["confirmPassword"].Errors.Clear();

            if (ModelState.IsValid)
            {
                try
                {
                    if (Membership.ValidateUser(admin.email, admin.password))
                    {
                        FormsAuthentication.SetAuthCookie(admin.email, false);
                        if (Roles.IsUserInRole(admin.email, "AdminRole"))
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                    }
                    return View();
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }


        [Authorize(Roles = "AdminRole")]
        [HttpGet]
        public ActionResult ParentRegister()
        {
            ViewBag.GenderID = new SelectList(db.Gender, "id", "name");
            ViewBag.CityID = new SelectList(db.City, "id", "name");

            return View();
        }
        [HttpPost]
        public ActionResult ParentRegister(Parent parent)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Parent.Add(parent);
                    db.SaveChanges();
                    return RedirectToAction("ParentRegister");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            else
            {
                return View();
            }
        }

        [Authorize(Roles = "AdminRole")]
        [HttpGet]
        public ActionResult StudentRegister()
        {
            ViewBag.GenderID = new SelectList(db.Gender, "id", "name");
            return View();
        }
        [HttpPost]
        public ActionResult StudentRegister(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Student.Add(student);
                    db.SaveChanges();
                    return RedirectToAction("StudentRegister");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            else
            {
                return View();
            }
        }

        [Authorize(Roles = "AdminRole")]
        [HttpGet]
        public ActionResult SchoolRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SchoolRegister(School school)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.School.Add(school);
                    db.SaveChanges();
                    return RedirectToAction("SchoolRegister");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            else
            {
                return View();
            }
        }
    }
}