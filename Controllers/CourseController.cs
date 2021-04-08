using SchoolEMS.Models;
using SchoolEMS.Models.Repositories;
using System;
using System.Web.Mvc;

namespace SchoolEMS.Controllers
{
    public class CourseController : Controller
    {
        private readonly IGenericRepository<Course> _repository = null;

        public CourseController()
        {
            _repository = new GenericRepository<Course>();
        }

        public CourseController(IGenericRepository<Course> repository)
        {

            _repository = repository;

        }
        // GET: Course

        [Authorize(Roles = "AdminRole")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CourseList()
        {
            try
            {
                _repository.GetProxyCreationEnabled();
                var courses = _repository.GetAll();
                return Json(new { Result = "OK", Records = courses });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult AddCourse(Course course)
        {
            try
            {
                Course addCourse = _repository.Add(course);
                _repository.Save();
                return Json(new { Result = "OK", Record = addCourse });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult UpdateCourse(Course course)
        {
            try
            {
                _repository.Update(course);
                _repository.Save();

                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult DeleteCourse(Course course)
        {
            try
            {
                _repository.Delete(course.id);
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