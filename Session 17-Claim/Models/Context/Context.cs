using Microsoft.EntityFrameworkCore

public class Context:DbContext
{ 
   //dbset
   public DbSet<Table_User> Table_Users {get; set;}
   public DbSet<Table_Role> Table_Roles {get; set;}
   public DbSet<Table_RoleUser> Table_RoleUsers {get; set;}


  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
     //optionsBuilder.UseSqlServer(@"Server=.;Database=Clean;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
     optionsBuilder.UseSqlServer(@"Server=.;Database=Claim;Encrypt=false;TrustServerCertificate=true;User=sa;Password=1361APassword");
  }

}


