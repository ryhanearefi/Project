using Microsoft.EntityFrameworkCore;
using Infrastructure.Data.Entities.User;


public class Context:DbContext
{

 public DbSet<Tb1_User> Tb1_Users { get; set; }


 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
     optionsBuilder.UseSqlServer(@"Server=.;Database=Clear;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
  }


}