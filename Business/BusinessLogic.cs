using Business.Factory;
using Business.Interfaces;
using Data;
using DataLayer.Interfaces;
using Models.Dtos;
using System.Collections.Generic;

namespace Business
{
    public class BusinessLogic
    {

        public ICalculateSalary CalulateProcess { get; set; }

        public IRepository Api { get; set; }

        public BusinessLogic()
        {                                  
            this.Api = new ApiEmployeeRepository();
        }

        public double CalculateEmployeeSalary()
        {
            return this.CalulateProcess.CalculateSalary();
        }

        public Employee GetEmployeedById(int id)
        {
            FactoryCalculateSalary factory = new FactoryCalculateSalary();
            Employee EmployeeResult = this.Api.GetEmployeById(id);

            if (EmployeeResult != null)
            {
                this.CalulateProcess = factory.GetInstance(EmployeeResult);
                EmployeeResult.annualsalary = this.CalculateEmployeeSalary();
            }

            return EmployeeResult;
        }


        public List<Employee> GetAllEmployees()
        {
            FactoryCalculateSalary factory = new FactoryCalculateSalary();
            List<Employee> allEmployees = this.Api.GetAllEmployee();
            if (allEmployees != null && allEmployees.Count > 0)
            {
                foreach (var employee in allEmployees)
                {
                    this.CalulateProcess = factory.GetInstance(employee);
                    employee.annualsalary = this.CalculateEmployeeSalary();
                }
            }

            return allEmployees;
        }



    }
}
