using Core.Domain.Model;

namespace Core.Myinterface;

public interface IUser
{

int SendSms(String phoneNumber);

void AddUser(MUser user);


bool CheckToken(String token);

}