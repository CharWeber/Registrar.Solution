using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
  public class CoursesController : Controller
  {
    private readonly RegistrarContext _db;

    public CoursesController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Course> model = _db.Courses.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Course course)
    {
      _db.Courses.Add(course);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      ViewBag.NoStudents = _db.Students.ToList().Count == 0;
      ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "Name");
      var thisCourse = _db.Courses
        .Include(course => course.StudentJoinEntities)
        .ThenInclude(join => join.Student)
        .Include(course => course.DepartmentJoinEntities)
        .ThenInclude(join => join.Department)
        .FirstOrDefault(course => course.CourseId == id);
        
      return View(thisCourse);
    }

    public ActionResult Edit(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    [HttpPost]
    public ActionResult Edit(Course course)
    {
      _db.Entry(course).State =  EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      _db.Courses.Remove(thisCourse);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult AddStudent(Course Course, int StudentId)
    {
      if (StudentId != 0)
      {
        _db.CourseStudent.Add(new CourseStudent() { StudentId = StudentId, CourseId = Course.CourseId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteStudent(int joinId)
    {
      var joinEntry = _db.CourseStudent.FirstOrDefault(entry => entry.CourseStudentId == joinId);
      _db.CourseStudent.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}