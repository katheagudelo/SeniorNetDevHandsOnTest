using Business.Factory;
using Business.Interfaces;
using Models.Dtos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsProject
{
    public class MonthlySalaryTest
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
            employee.contractTypeName = "MonthlySalaryEmployee";


        }

        [Test]
        public void CalculateHourlySalary()
        {
            FactoryCalculateSalary factory = new FactoryCalculateSalary();
            calculate = factory.GetInstance(this.employee);
            double annualSalary = calculate.CalculateSalary();
            Assert.AreEqual(annualSalary, 960000);
        }
    }
}
