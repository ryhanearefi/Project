using Microsoft.EntityFrameworkCore;

public class Context: DbContext
{
  
public DbSet<Tbl_Product> Tbl_Products {get; set;}
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
     //optionsBuilder.UseSqlServer(@"Server=.;Database=Clean;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
     optionsBuilder.UseSqlServer(@"Server=.;Database=CQRS;Encrypt=false;TrustServerCertificate=true;User=sa;Password=1361APassword");
  }



}