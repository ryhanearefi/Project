

using Core.Domain.Model;
using Core.Myinterface;
using Infrastructure.Data.Entities.User;

public class User : IUser

{

    private readonly Context db; 

    public User(Context _db)
    {
      db = _db;
    }



  public void AddUser(MUser user)
  {
      Tb1_User us =new Tb1_User();

      //maping manual
        us.Name = user.Name;
        us.PhoneNumber = user.PhoneNumber;
        us.Token = user.Token;
        db.Tb1_Users.Add(us);
        db.SaveChanges();

  }

  public bool CheckToken(string token)
  {
    throw new NotImplementedException();
  }

  public void SendSms(string phoneNumber)
  {
    throw new NotImplementedException();
  }
}