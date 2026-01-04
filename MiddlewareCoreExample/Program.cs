/* //1. Default ASP.NET Core Web Application setup with middleware configuration.
  
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

app.Run(); */

/* //2. Using Run Extension Method to Configure Inline Middleware Component.
  
 
var builder = WebApplication.CreateBuilder(args);

// Builds the web application based on the configured settings
var app = builder.Build();
//Configuring New Inline Middleware Component using Run Extension Method
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Getting Response from First Middleware");
});
// Starts the web application which begins listening for incoming requests
app.Run(); **/

/* //3. Using Multiple Run Extension Methods to Configure Inline Middleware Components.
  //We need to use Use() Extension Method to chain multiple middleware components.
  
  // Initializes the configuration for the web application
            var builder = WebApplication.CreateBuilder(args);
            
            // Builds the web application based on the configured settings
            var app = builder.Build();
            //Configuring First Middleware Component using Use Extension Method
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Getting Response from First Middleware");
                await next();
            });
            //Configuring Second Middleware Component using Run Extension Method
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("\nGetting Response from Second Middleware");
            });
            // Starts the web application which begins listening for incoming requests
            app.Run();**/

/* //4. Using Multiple Use Extension Methods to Configure Inline Middleware Components.
  // We need to use Use() Extension Method to chain multiple middleware components as Run() does not support chaining next() to invoke the next middleware.
  // Initializes the configuration for the web application
            var builder = WebApplication.CreateBuilder(args);
            
            // Builds the web application based on the configured settings
            var app = builder.Build();
            //Configuring First Middleware Component using Use Extension Method
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Getting Response from First Middleware");
                await next();
            });
            //Configuring Second Middleware Component using Run Extension Method
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("\nGetting Response from Second Middleware");
                await next();
            });

    //Configuring Second Middleware Component using Run Extension Method
    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("\nGetting Response from Final Middleware");
    });

    // Starts the web application which begins listening for incoming requests
    app.Run(); */

/* //5. Instead of passing the request delegate as an inline anonymous method, we can define it in a separate method and pass it like below 

    public class Program
    {
        public static void Main(string[] args)
        {
            // Initializes the configuration for the web application
            var builder = WebApplication.CreateBuilder(args);
            
            // Builds the web application based on the configured settings
            var app = builder.Build();

            //Configuring New Inline Middleware Component using Run Extension Method
            app.Run(FirstMiddleware);

            // Starts the web application which begins listening for incoming requests
            app.Run();
        }

        //This method signature must be the same as the RequestDelegate signature
        private static async Task FirstMiddleware(HttpContext context)
        {
            //Using context object, we can access both Request and Response
            await context.Response.WriteAsync("Getting Response from First Middleware");
        }
    } */

/* //6. Using Custom Middleware Class in ASP.NET Core Application 
// Initializes the configuration for the web application
using MiddlewareCoreExample.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Builds the web application based on the configured settings
var app = builder.Build();

//Using Custom Middleware Class
app.UseMiddleware<CustomMiddleware>(); 

//Configuring First Middleware Component using Use Extension Method
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Getting Response from First Middleware");
    await next();
});
//Configuring Second Middleware Component using Run Extension Method
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\nGetting Response from Second Middleware");
    await next();
});

//Configuring Second Middleware Component using Run Extension Method
app.Run(async (context) =>
{
    await context.Response.WriteAsync("\nGetting Response from Final Middleware");
});

// Starts the web application which begins listening for incoming requests
app.Run(); */




