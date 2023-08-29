using System.ComponentModel.DataAnnotations;
public class Tbl_Menu
{
  [Key]
  public int Id { get; set; }
  public string CatName { get; set; }
  public int ParentId { get; set; }
  public bool Status { get; set; }

    
}