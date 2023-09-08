using BlogApp.IdentityCustomization;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>(x =>
{
    x.Password.RequiredLength = 6;
    x.Password.RequireNonAlphanumeric = true;
    x.Password.RequireLowercase = true;
    x.Password.RequireUppercase = true;
    x.Password.RequireDigit = true;
})
    .AddEntityFrameworkStores<Context>()
    .AddErrorDescriber<CustomIdentityErrorDescriber>();

builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x =>
    {
        x.LoginPath = "/Login/Index";
    }
);

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromDays(30);
    options.LoginPath = "/Login/Index/";
    options.LogoutPath = "/Login/Logout/";
    options.AccessDeniedPath = new PathString("/Login/AccessDenied");
    options.SlidingExpiration = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.UseHttpsRedirection();

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "Admin",
    pattern: "/admin/{controller=Home}/{action=Index}/{id?}",
    defaults: new { area = "Admin" },
    constraints: new { area = "Admin" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Blog}/{action=Index}/{id?}"
);

app.Run();

//app.UseAuthentication();
//app.UseAuthorization(); 

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//            name: "areas",
//            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//});

//public void ConfigureServices(IServiceCollection services)
//{
//    services.AddControllersWithViews();

//    services.AddMvc(config =>
//    {
//        var policy = new AuthorizationPolicyBuilder()
//        .RequireAuthenticatedUser()
//        .Build();
//        config.Filters.Add(new AuthorizeFilter(policy));
//    });
//}


