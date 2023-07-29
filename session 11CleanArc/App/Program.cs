using Core.Myinterface;
using Core.Interface.User;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//adddbcontext
 builder.Services.AddDbContext<Context>();

 builder.Services.AddScoped<IUser, User>();

 builder.Services.AddScoped<IStudent, Student>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//route area admin

app.MapAreaControllerRoute(
    name: "default",
    areaName: "admin",
    pattern: "admin/{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
