using Microsoft.EntityFrameworkCore;
using Session_19_Menu_.Models.Entities;

namespace Session_19_Menu_.Models.Context;
public class Context : DbContext

{
    //dbset
    public DbSet<Tbl_Menu> Tbl_Menus { get; set; }
    public object Tbl_Menu {get;internal set;}


  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    //docker run -itd --network=host -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=1361APassword" mcr.microsoft.com/mssql/server:2019-latest
    optionsBuilder.UseSqlServer(@"Server=.;Database=Menu;Encrypt=false;TrustServerCertificate=true;User=sa;Password=1361APassword");
  }

}

