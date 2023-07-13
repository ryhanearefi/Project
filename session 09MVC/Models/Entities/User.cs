using System.ComponentModel.DataAnnotations;
public class User
{
  

  
  [Key]
  public int Id { get; set; }
    
  public string Phone { get; set; }

   public string Code { get; set; }
  
  
}