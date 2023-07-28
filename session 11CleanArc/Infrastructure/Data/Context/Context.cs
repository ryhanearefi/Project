using Microsoft.EntityFrameworkCore;
using Infrastructure.Data.Entities.User;


public class Context:DbContext
{

 public DbSet<Tb1_User> Tb1_Users { get; set; }

 //Tb1_Student
 public DbSet<Tb1_Student> Tb1_Students { get; set; } 


 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
     //optionsBuilder.UseSqlServer(@"Server=.;Database=Clean;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
     optionsBuilder.UseSqlServer(@"Server=.;Database=Clean;Encrypt=false;TrustServerCertificate=true;User=sa;Password=1361APassword");
  }


}