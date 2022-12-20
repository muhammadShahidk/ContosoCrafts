using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("return")]
    public class EmployeeControler:Controller
    {
        public EmployeeControler()
        {

        }

        //[Route("return")] //this is the other way to route
        [HttpGet]
        public ViewResult Hello()
        {
            //return "shahid form emp controllers";
            EmployeeGetService employeeGetService = new EmployeeGetService();
            Employee model = employeeGetService.GetEmployees().Find(x => x.Name =="Umar");
            
            return View(model);
        }

    }
}
