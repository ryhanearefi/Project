using System.ComponentModel.DataAnnotations;

public class Table_RoleUser
{
  [Key]
  public int Id { get; set; }
  public int RoleId { get; set; }
  public int UserId { get; set; }

  
  
}