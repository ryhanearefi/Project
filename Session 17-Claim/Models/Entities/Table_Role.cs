using System.ComponentModel.DataAnnotations;
public class Table_Role
{
  [Key]
   public int Id { get; set; }

   public string RoleName { get; set; }

   public bool Menu_Privacy { get; set; }
    public bool IdRole { get; internal set; }
}