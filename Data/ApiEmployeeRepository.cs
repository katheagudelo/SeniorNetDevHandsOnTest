using DataLayer.Controllers;
using DataLayer.Interfaces;
using Models.Dtos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Data
{
    public class ApiEmployeeRepository : ApiControllerBase, IRepository
    {
        public ApiEmployeeRepository():base()
        {

        }
        public List<Employee> GetAllEmployee()
        {
            List<Employee> employees = null;

            HttpResponseMessage result = this.Get();

            if (result.IsSuccessStatusCode)
            {
                employees = JsonConvert.DeserializeObject<List<Employee>>(result.Content.ReadAsStringAsync().Result);
            }

            return employees;

        }

        public Employee GetEmployeById(int id)
        {
            List<Employee> employees = this.GetAllEmployee();
            return employees.FirstOrDefault(e => e.id == id);
        }
    }
}
