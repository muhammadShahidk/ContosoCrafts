using System.Collections.Generic;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.WebSite.Pages
{
    public class EmployeeModel : PageModel
    {
        public List<Employee> employees = new List<Employee>();
        public EmployeeGetService employeeGet1;
        public EmployeeModel(EmployeeGetService employeeGet )
        {
            employeeGet1 = employeeGet;
        }
        public void OnGet()
        {
           employees= employeeGet1.GetEmployees();
        }

      
        //public void ClickedSave()
        //{
        //   string Name =  Request.Form["Name"];
          
        //}
    }
}
