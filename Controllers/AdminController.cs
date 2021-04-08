using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolEMS.Models;

namespace SchoolEMS.Controllers
{

    [Authorize(Roles = "AdminRole")]
    public class AdminController : Controller
    {
        readonly AdminDashEntities db = new AdminDashEntities();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Course()
        {
            ViewBag.SemesterID = new SelectList(db.Semester, "id", "name");
            return View();
        }
        [HttpPost]
        public ActionResult Course(Course course)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Course.Add(course);
                    db.SaveChanges();
                    return RedirectToAction("Course");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            ModelState.AddModelError("", "Error");
            return View();
        }


        [HttpGet]
        public ActionResult Task()
        {
            ViewBag.SemesterID = new SelectList(db.Semester, "id", "name");
            ViewBag.CourseId = new SelectList(db.Course, "id", "name");
            return View();
        }
        [HttpPost]
        public ActionResult Task(Task task, HttpPostedFileBase taskFile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (taskFile != null)
                    {
                        string imagePath = Server.MapPath("~/Content/Images/Task/");
                        task.taskFile = FileStores(imagePath, taskFile); ;
                    }

                    db.Task.Add(task);
                    db.SaveChanges();
                    return RedirectToAction("Task");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            ModelState.AddModelError("", "Error");
            return View();
        }

        public JsonResult GetCourseBySemesterId(int SemesterId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var data = db.Course.Where(a => a.semesterId == SemesterId).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public ActionResult Grade()
        {
            ViewBag.GradeTypeID = new SelectList(db.GradeType, "id", "name");
            return View();
        }
        [HttpPost]
        public ActionResult Grade(Grade grade, HttpPostedFileBase gradeFile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (gradeFile != null)
                    {
                        string imagePath = Server.MapPath("~/Content/Images/Grade/");
                        grade.gradeFile = FileStores(imagePath, gradeFile); ;
                    }

                    db.Grade.Add(grade);
                    db.SaveChanges();
                    return RedirectToAction("Grade");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            ModelState.AddModelError("", "Error");
            return View();
        }

        private string FileStores(string imagePath, HttpPostedFileBase gradeFile)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult Attendance()
        {
            ViewBag.AttendanceTypeID = new SelectList(db.AttendanceType, "id", "name");
            return View();
        }
        [HttpPost]
        public ActionResult Attendance(Attendance attendance, HttpPostedFileBase attendanceFile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (attendanceFile != null)
                    {
                        string imagePath = Server.MapPath("~/Content/Images/Attendance/");
                        attendance.attendanceFile = FileStores(imagePath, attendanceFile); ;
                    }

                    db.Attendance.Add(attendance);
                    db.SaveChanges();
                    return RedirectToAction("Attendance");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            ModelState.AddModelError("", "Error");
            return View();
        }


        [HttpGet]
        public ActionResult Event()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Event(Event ev)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Event.Add(ev);
                    db.SaveChanges();
                    return RedirectToAction("Event");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            ModelState.AddModelError("", "Error");
            return View();
        }


        
        [HttpGet]
        public ActionResult Activity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Activity(Activity activity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Activity.Add(activity);
                    db.SaveChanges();
                    return RedirectToAction("Activity");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            ModelState.AddModelError("", "Error");
            return View();
        }


        [HttpGet]
        public ActionResult Schedule()
        {
            ViewBag.ScheduleTypeID = new SelectList(db.ScheduleType, "id", "name");
            return View();
        }
        [HttpPost]
        public ActionResult Schedule(Schedule schedule, HttpPostedFileBase scheduleFile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (scheduleFile != null)
                    {

                        string imagePath = Server.MapPath("~/Content/Images/Schedule/");
                        schedule.scheduleFile = FileStores(imagePath, scheduleFile);
                    }
                    db.Schedule.Add(schedule);
                    db.SaveChanges();
                    return RedirectToAction("Schedule");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            ModelState.AddModelError("", "Error");
            return View();
        }


        [HttpGet]
        public ActionResult Report()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Report(Report report)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Report.Add(report);
                    db.SaveChanges();
                    return RedirectToAction("Report");
                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            ModelState.AddModelError("", "Error");
            return View();
        }
    }
}