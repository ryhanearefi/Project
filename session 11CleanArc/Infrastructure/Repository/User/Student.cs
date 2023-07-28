using Core.Interface.User;
using Domain.User;

public class Student : IStudent
{
  
  private readonly Context db;

  public Student(Context db)
  {
    this.db = db;
  }


  public void AddStudent(MStudent student)
  {
    var tb1Student = new Tb1_Student();
    tb1Student.Name = student.Name;
    tb1Student.Family = student.Family;
    tb1Student.Phone = student.Phone;


    db.Tb1_Students.Add(tb1Student);
    db.SaveChanges();
  }

  public void DeleteStudent(int id)
  {
    
   var student = db.Tb1_Students.Find(id);
   db.Tb1_Students.Remove(student);
   db.SaveChanges();


  }

  public List<MStudent> GetAllStudent()
  {
    var List = db.Tb1_Students.ToList();
    
    List<MStudent> st = new List<MStudent> ();

    foreach (var item in List)
    {
      MStudent ms = new MStudent();
      ms.Id= item.Id;
      ms.Name = item.Name;
      ms.Family = item.Family;
      ms.Phone = item.Phone;



      st.Add(ms);
    }
    return st;

  }

  public MStudent GetStudentById(int id)
  {
    var student = db.Tb1_Students.Find(id);

    MStudent ms = new MStudent();
    ms.Name = student.Name;
    ms.Family = student.Family;
    ms.Phone = student.Phone;
    ms.Id = student.Id;


    return ms;

  }

  public void UpdateStudent(MStudent student)
  {
    var tb1Student = db.Tb1_Students.Find(student.Id);
    tb1Student.Name=student.Name;
    tb1Student.Family=student.Family;
    tb1Student.Phone=student.Phone;


  db.SaveChanges();

  }
}