using Core.Domain.Model;

namespace Core.Myinterface;

public interface IUser
{

void SendSms(String phoneNumber);

void AddUser(MUser user);


bool CheckToken(String token);

}