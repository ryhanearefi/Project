using System.ComponentModel.DataAnnotations;

public class Tbl_Product
{
  [Key]
  public Guid Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public decimal Price { get; set; }
  public string Color { get; set; }
}





