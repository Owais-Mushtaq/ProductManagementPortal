using Microsoft.AspNetCore.Mvc;
//Controller is a group of action methods...inherets from base class controller.
//action method is used to handle request.
//Request is mapped to one of controller's action method.
//Name convention of Controller must contain suffix Controller.
//Mapping request to Controller --> Action Method to handle request.
namespace InventoryManagementPortal.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    // return View();
        //    return "Hello from MVC using Index method; for second method output use route /home/MethodName.";
        //}

        //public string SecondActionMethod()
        //{
        //    return "Second action method with string output";
        //}

        public IActionResult Index()
        {
            return View();

        }

    }
}
