using Business.Controllers;
using Business.Interfaces;
using Models.Dtos;

namespace Business.ConcreteImplementation
{
    class CalculateMonthySalary : CalculateSalaryBase, ICalculateSalary
    {
        public new Employee _employee { get; set; }

        public CalculateMonthySalary(Employee employee):base(employee)
        {
            this._employee = employee;
        }

        public double CalculateSalary()
        {
            double salary;
            salary = _employee.monthlySalary * 12;
            return salary;
        }
    }
}
