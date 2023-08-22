using Microsoft.EntityFrameworkCore;
using Infrastructure.Data.Entities.User;


public class Context:DbContext
{

 public DbSet<Tb1_User> Tb1_Users { get; set; }

 //Tb1_Student
 public DbSet<Tb1_Student> Tb1_Students { get; set; } 


 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
     //docker run -itd --network=host -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=1361APassword" mcr.microsoft.com/mssql/server:2019-latest
     optionsBuilder.UseSqlServer(@"Server=.;Database=Clean;Encrypt=false;TrustServerCertificate=true;User=sa;Password=1361APassword");
  }


}
