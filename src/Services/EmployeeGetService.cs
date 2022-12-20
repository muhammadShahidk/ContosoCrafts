using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using ContosoCrafts.WebSite.Models;

namespace ContosoCrafts.WebSite.Services
{
    public class EmployeeGetService
    {

        public EmployeeGetService()
        {

        }
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            DateTime date= DateTime.Now;
            employees.Add(new Employee { Name = "Shahid", Age =date ,Phone = "032451", Address = "lahore" });
            employees.Add(new Employee { Name = "Shahid", Age = date , Phone = "032451", Address = "lahore" });
            employees.Add(new Employee { Name = "Shahid", Age = date , Phone = "032451", Address = "lahore" });
            employees.Add(new Employee { Name = "Shahid", Age = date , Phone = "032451", Address = "lahore" });
            employees.Add(new Employee { Name = "Shahid", Age = date , Phone = "032451", Address = "lahore" });
            employees.Add(new Employee { Name = "Umar", Age = date , Phone = "032451", Address = "lahore" });

            return employees;
        }
    }

}
