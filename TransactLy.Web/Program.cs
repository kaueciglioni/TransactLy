using Microsoft.EntityFrameworkCore;
using TransactLy.Web.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TransactLyContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("TransactLyContext")
        ?? throw new InvalidOperationException("Connection string 'TransactLyContext' not found."),
        new MySqlServerVersion(new Version(8, 0, 40))
    )
);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<SeedingService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var seedingService = services.GetRequiredService<SeedingService>();
        seedingService.Seed();
    }
}

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
