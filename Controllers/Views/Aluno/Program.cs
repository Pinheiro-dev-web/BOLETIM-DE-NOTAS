var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Define para abrir o sistema diretamente na nossa lista de alunos
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Aluno}/{action=Listar}/{id?}");

app.Run();
