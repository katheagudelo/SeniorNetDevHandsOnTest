using Business.Controllers;
using Business.Interfaces;
using Models.Dtos;

namespace Business.ConcreteImplementation
{
    class CalculateHourlySalary : CalculateSalaryBase, ICalculateSalary
    {
        public new Employee _employee { get; set; }

        public CalculateHourlySalary(Employee employee):base(employee)
        {
            this._employee = employee;
        }

        public double CalculateSalary()
        {
            double salary;
            salary = 120 * _employee.hourlySalary * 12;
            return salary;
        }
    }
}
