using GmailRegistration.Data;
using GmailRegistration.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<GmailDBContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DBConnection"));
});
// Add Session services
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set appropriate timeout
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
// Register Services
builder.Services.AddScoped<IGenerateEmailSuggestions, GenerateEmailSuggestions>();
builder.Services.AddSingleton<IPhoneVerification, PhoneVerification>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IRegistrationSessionService, RegistrationSessionService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Registration}/{action=Step1}/{id?}");
    


app.Run();
