using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Web1.Data;
using Web1.Repository;
using Web1.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    )
);

builder.Services.AddTransient<IFooterService, FooterService>();
builder.Services.AddTransient<IServiceFeatureService, ServiceFeatureService>();
builder.Services.AddTransient<IHeaderService, HeaderService>();
builder.Services.AddTransient<IContactService, ContactService>();
builder.Services.AddScoped<IPartnersService, PartnersService>();
builder.Services.AddScoped<IIntroduceService, IntroduceService>();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<ITestYoneService, TestYoneService>();
builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IIntroductoryPostRepo, IntroductoryPostRepo>();
builder.Services.AddTransient<IUploadFileService, UploadFileService>();
builder.Services.AddTransient<IConfigurationRepo, ConfigurationRepo>();
builder.Services.AddTransient<ISettingService, SettingService>();
builder.Services.AddTransient<IPartnerPepo, PartnerRepo>();
builder.Services.AddTransient<IPartnerService, PartnerService>();

builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Home/Login";
        options.LogoutPath = "/Home/Logout";
    });

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=HomeAdmin}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
