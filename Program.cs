using Intro.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddScoped();
//������ ������� ���������� ���������� ������ ������ ������������,
//������� � ���� ������ ��� �������� ������ ������ ����������� � 0 
//builder.Services.AddTransient();
//��������� ������ ��������� ��� ����� ������ �� ���� ���������� ������ 1 
builder.Services.AddSingleton<iServiceCounter,ServicesCounter>();
//����� ��� ������� ���������� ������ �� ���� ������������� � ���� ������ �� ���� ��� ���������� � 1 �������
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
