
using SchoolEMS.Models;
using SchoolEMS.Models.Repositories;
using System;
using System.Web.Mvc;

namespace SchoolEMS.Controllers
{
    public class UserController : Controller
    {
        private readonly IGenericRepository<Admin> _repository = null;

        public UserController()
        {
            _repository = new GenericRepository<Admin>();
        }

        public UserController(IGenericRepository<Admin> repository)
        {

            _repository = repository;

        }
        // GET: Admin

        [Authorize(Roles = "AdminRole")]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult AdminList()
        {
            try
            {
                _repository.GetProxyCreationEnabled();
                var admins = _repository.GetAll();
                return Json(new { Result = "OK", Records = admins });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }


        [HttpPost]
        public JsonResult AddAdmin(Admin admin)
        {
            try
            {
                Admin addAdmin = _repository.Add(admin);
                _repository.Save();

                return Json(new { Result = "OK", Record = addAdmin });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult UpdateAdmin(Admin admin)
        {
            try
            {
                _repository.Update(admin);
                _repository.Save();

                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult DeleteAdmin(Admin admin)
        {
            try
            {
                _repository.Delete(admin.id);
                _repository.Save();
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}