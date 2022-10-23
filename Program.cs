using Intro.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddScoped();
//скопед считает конкретное количество кликов одного пользователя,
//который в этой сессии при закрытии сессии данные обновляются с 0 
//builder.Services.AddTransient();
//транзишен каждое обращение это новый объект то есть количество всегда 1 
builder.Services.AddSingleton<iServiceCounter,ServicesCounter>();
//сингл тон считает количество кликов от всех пользователей в этой сессии то есть все обращаются к 1 объекту
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
