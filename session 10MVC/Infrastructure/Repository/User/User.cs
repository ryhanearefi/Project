

using Core.Domain.Model;
using Core.Myinterface;
using Infrastructure.Data.Entities.User;
using Kavenegar;

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

  public int SendSms(string phoneNumber)
  {
    Random rnd = new Random();
      string number = rnd.Next(1000, 9999).ToString();

        var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D"); 
         api.VerifyLookup(phoneNumber, number,"demo");
return int.Parse(number);

  }
}