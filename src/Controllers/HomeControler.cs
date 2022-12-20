using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.WebSite.Controllers
{
    public class HomeControler:Controller
    {
        public string Index()
        {
            return "Hello from MVC";
        }
    }
}
