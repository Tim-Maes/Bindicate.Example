using Bindicate;
using Bindicate.Project;
using Bindicate.ProjectWithOptions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

//Configure bindicate for host
builder.Services.AddAutowiringForAssembly(Assembly.GetExecutingAssembly())
    .Register();

builder.Services.AddProject();

var configuration = builder.Configuration;
builder.Services.AddProjectWithOptions(configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
