using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System_Models;

namespace SystemDemo.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult Master()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetThreeNav()
        {
            string id = Request.Form["id"].ToString();

            List<Employee> employee = new List<Employee>();
            for (int i = 0; i < 3; i++)
            {
                employee.Add(new Employee());
                employee[i].Emp_Id = Guid.NewGuid().ToString();
                employee[i].Emp_Name = "123";
            }
            return Json(employee);
        }
    }
}
