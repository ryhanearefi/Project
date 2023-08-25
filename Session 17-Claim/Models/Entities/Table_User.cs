using System.ComponentModel.DataAnnotations;

public class Table_User
{
  [Key]
  public int id {get; set; }
  public string username {get; set; }
  public string password {get; set; }

  public string Name {get; set; }
  public string Family {get; set; }
  public string Email {get; set; }
  public string Mobile {get; set; } 
 
}