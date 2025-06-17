using Web1.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IFooterService, FooterService>();
builder.Services.AddTransient<IServiceFeatureService, ServiceFeatureService>();
builder.Services.AddTransient<IHeaderService, HeaderService>();
builder.Services.AddTransient<IBlock6Service, Block6Service>();
builder.Services.AddScoped<IPartnersService, PartnersService>();
builder.Services.AddScoped<IIntroduceService, IntroduceService>();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<IBlock3Service, Block3Service>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
