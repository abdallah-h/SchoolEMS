using SchoolEMS.Models;
using SchoolEMS.Models.Repositories;
using System;
using System.Web.Mvc;

namespace SchoolEMS.Controllers
{
    public class SchoolController : Controller
    {
        private readonly IGenericRepository<School> _repository = null;

        public SchoolController()
        {
            _repository = new GenericRepository<School>();
        }

        public SchoolController(IGenericRepository<School> repository)
        {

            _repository = repository;

        }

        [Authorize(Roles = "AdminRole")]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult SchoolList()
        {
            try
            {
                _repository.GetProxyCreationEnabled();
                var schools = _repository.GetAll();
                return Json(new { Result = "OK", Records = schools });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }


        [HttpPost]
        public JsonResult AddSchool(School school)
        {
            try
            {
                School addSchool = _repository.Add(school);
                _repository.Save();

                return Json(new { Result = "OK", Record = addSchool });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult UpdateSchool(School school)
        {
            try
            {
                _repository.Update(school);
                _repository.Save();

                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult DeleteSchool(School school)
        {
            try
            {
                _repository.Delete(school.id);
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