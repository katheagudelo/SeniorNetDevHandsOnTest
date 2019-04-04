using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface IRepository
    {
        Employee GetEmployeById(int id);

        List<Employee> GetAllEmployee();
    }
}
