

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();


app.MapDefaultControllerRoute();

// app.UseMvc(x=>{
//     x.MapRoute(
//         name:"default",
//         template:"{controller}/{action}/{id?}"
//     );
// });

app.Run();
