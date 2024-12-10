namespace InventoryManagementPortal;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        //adding dependency for builder services ..AddControllerwithViews. 
        builder.Services.AddControllersWithViews();
        var app = builder.Build();
        //middleware for bootstrap type static files access.
        app.UseStaticFiles();

        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
            );

        //app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}
