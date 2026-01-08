using DependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);
// Add Framework MVC services to the Container.
builder.Services.AddMvc();
//Application Service
builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
//builder.Services.AddSingleton(typeof(IStudentRepository), typeof(StudentRepository));
//builder.Services.AddTransient<IStudentRepository, StudentRepository>();
//builder.Services.AddTransient(typeof(IStudentRepository), typeof(StudentRepository));
//builder.Services.AddScoped<IStudentRepository, StudentRepository>();
//builder.Services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));
//Add Application Service to the Container.
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository),
//    new StudentRepository())); // by default singleton
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository),
//    typeof(StudentRepository), ServiceLifetime.Singleton)); // singleton
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository),
//    typeof(StudentRepository), ServiceLifetime.Transient)); // Transient
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository),
//    typeof(StudentRepository), ServiceLifetime.Scoped));    // Scoped
var app = builder.Build();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.Run();