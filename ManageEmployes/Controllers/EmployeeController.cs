using System.Collections.Generic;
using Business;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos;

namespace ManageEmployes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public List<Employee> employeeList { get; set; }

        [HttpGet]
        [HttpGet("{id}")]
        public IActionResult Get(int? id = null)
        {
                BusinessLogic bussiness = new BusinessLogic();

            if (id != null)
            {
                employeeList = new List<Employee>();
                Employee employee =  bussiness.GetEmployeedById((int)id);
                employeeList.Add(employee);
            }
            else
            {
                employeeList = bussiness.GetAllEmployees();
            }

            return Ok(employeeList);
        }
    }
}