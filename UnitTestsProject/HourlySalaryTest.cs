using Business.Factory;
using Business.Interfaces;
using Models.Dtos;
using Moq;
using NUnit.Framework;

namespace UnitTestsProject
{
    public class Tests
    {
        public ICalculateSalary calculate { get; set; }

        Employee employee = new Employee();

        [SetUp]
        public void Setup()
        {
            employee.id = 1;
            employee.name = "Katherine";
            employee.monthlySalary = 80000;
            employee.hourlySalary = 60000;
            employee.contractTypeName = "HourlySalaryEmployee";


        }

        [Test]
        public void CalculateHourlySalary()
        {
            FactoryCalculateSalary factory = new FactoryCalculateSalary();
            calculate = factory.GetInstance(this.employee);
            double annualSalary = calculate.CalculateSalary();
            Assert.AreEqual(annualSalary, 86400000);
        }
    }
}