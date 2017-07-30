using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;

namespace DataAccessLayer
{
    public class DataAccess
    {
        public virtual IList<Employee> GetEmployeeData()
        {
            var employees = new Employee[1];
            employees[0] = new Employee { EmployeeId = "111", EmployeeName = "John Sherman" };
            return new List<Employee>(employees);
        }
    }
}
