using Microsoft.EntityFrameworkCore;


public class Context:DbContext

{ 
   //dbset
   public DbSet<Table_User>Table_Users {get; set;}
   public DbSet<Table_Role>Table_Roles {get; set;}
   public DbSet<Table_RoleUser>Table_RoleUsers {get; set;}
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
     
    // optionsBuilder.UseSqlServer(@"Server=.;Database=Claim;Encrypt=false;TrustServerCertificate=true;User=sa;Password=1361APassword");
     optionsBuilder.UseSqlServer(@"Server=finn.iran.liara.ir,33958;Initial Catalog=myDB;Database=Claim;Encrypt=false;TrustServerCertificate=true;User=sa;Password=bEqdPqlDjcCj2omigydDmPBo");
    // Data Source=dreamy-maxwell-id40t5ihi-db,1433;Initial Catalog=myDB;User Id=sa;Password=bEqdPqlDjcCj2omigydDmPBo;
    //Data Source=finn.iran.liara.ir,33958;Initial Catalog=myDB;User Id=sa;Password=bEqdPqlDjcCj2omigydDmPBo;
  }

}


