using Business.ConcreteImplementation;
using Business.Interfaces;
using Models.Dtos;

namespace Business.Factory
{
    public class FactoryCalculateSalary
    {

        public ICalculateSalary GetInstance(Employee employe)
        {
            ICalculateSalary instance = null;

            switch (employe.contractTypeName)
            {
                case "HourlySalaryEmployee":
                    instance = new CalculateHourlySalary(employe);
                    break;

                case "MonthlySalaryEmployee":
                    instance = new CalculateMonthySalary(employe);
                    break;
                default:
                    break;
            }


            return instance;
        }
    }
}
