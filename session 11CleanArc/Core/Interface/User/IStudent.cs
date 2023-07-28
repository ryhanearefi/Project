using Domain.User;

namespace  Core.Interface.User;


public interface IStudent
{
  //Create
   void AddStudent(MStudent student);

   //Read
   List<MStudent> GetAllStudent();

   
   //Update
   void UpdateStudent(MStudent student);


   //Delete
   void DeleteStudent(int id);
  

  //Getby ID
  MStudent GetStudentById(int id);

}