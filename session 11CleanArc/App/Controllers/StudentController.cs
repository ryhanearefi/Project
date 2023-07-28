using Core.Interface.User;
using Domain.User;
using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
  private readonly IStudent _student;

  public StudentController(IStudent student)
  {
    _student = student;
  }
  
public IActionResult index()
    {
        ViewBag.List = _student.GetAllStudent();
        return View();
    }

public IActionResult addstudent(MStudent st)
{
    _student.AddStudent(st);
     return RedirectToAction("index");

}


public IActionResult delete(int id)
{
    _student.DeleteStudent(id);
     return RedirectToAction("index");

}


public IActionResult edit(int id)
{
     var student = _student.GetStudentById(id);
     return View(student);

}

//UpdateStudent

public IActionResult UpdateStudent(MStudent st)
{
     _student.UpdateStudent(st);
     return RedirectToAction("index");

}



}