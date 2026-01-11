using TypesOfServicesInCore.Models;

namespace TypesOfServicesInCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
            builder.Services.AddSingleton<SomeOtherService>();

            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<SomeOtherService>();

            builder.Services.AddTransient<IStudentRepository, StudentRepository>();
            builder.Services.AddTransient<SomeOtherService>();

            builder.Services.AddMvc();
            // Build the application using the configured builder
            var app = builder.Build();
            // Enable routing middleware, which matches incoming HTTP requests to endpoints defined in the application
            app.UseRouting();
            // Map the default controller route (convention: {controller=Home}/{action=Index}/{id?})
            // This means if no specific route is provided, it will default to HomeController and Index action
            app.MapControllerRoute(
                name: "default", // Name of the route
                pattern: "{controller=Home}/{action=Index}/{id?}" // URL pattern for the route
            );
            // Run the application, which blocks the calling thread and starts listening for incoming HTTP requests
            app.Run();
        }
    }
}
