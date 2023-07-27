using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities.User;

public class Tb1_User

{

  [Key]
   public int ID { get; set; }

  public string Name { get; set; }

  public string PhoneNumber { get; set; }

  public string Token { get; set; }


}