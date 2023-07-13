

using Microsoft.EntityFrameworkCore;

public class Context : DbContext
 {
   public DbSet<User> Users { get; set; }


  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
     optionsBuilder.UseSqlServer(@"Server=.;Database=shoptest;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
  }





 }