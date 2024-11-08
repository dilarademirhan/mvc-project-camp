using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Session yapılandırması
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromMinutes(30);
	options.Cookie.HttpOnly = true;
	options.Cookie.IsEssential = true;
});

// Cookie tabanlı kimlik doğrulama yapılandırması
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
	{
		options.LoginPath = "/Login/Index";
		options.AccessDeniedPath = "/Login/Index";  
		options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
	});

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseStatusCodePagesWithReExecute("/ErrorPage/{0}");
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Kimlik doğrulama ve yetkilendirme middleware'lerini etkinleştir
app.UseAuthentication();
app.UseAuthorization();

// Session'ı etkinleştir
app.UseSession();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
