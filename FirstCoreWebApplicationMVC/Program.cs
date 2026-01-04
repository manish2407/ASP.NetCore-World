namespace FirstCoreWebApplicationMVC
{
    public class Program
    {
        /** 1. Default ASP.NET Core 8.0 MVC Program.cs structure
         *
         * public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
        }**/

        // 2. Accessing Configuration Values from the appSettings.json file in ASP.NET Core 8.0 Program.cs
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            //ConfigurationManager configuration = builder.Configuration;
            //Get the Configuration Value using Generic GetValue
            string? MyCustomKeyValue1 = builder.Configuration.GetValue<string>("MyCustomKey", "DefaultValue");

            //Get the Configuration Value using Indexer
            string? MyCustomKeyValue = builder.Configuration["MyCustomKey"];

            app.MapGet("/", () => $"{MyCustomKeyValue}");
            app.Run();
        }
    }
}
