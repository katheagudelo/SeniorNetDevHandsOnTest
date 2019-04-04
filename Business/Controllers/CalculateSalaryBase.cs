using Models.Dtos;

namespace Business.Controllers
{
    class CalculateSalaryBase
    {
        public Employee _employee { get; set; }

        public CalculateSalaryBase(Employee employee)
        {
            this._employee = employee;
        }
    }
}
