using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class OracleDataAccess : DataAccess
    {
        public override IList<Employee> GetEmployeeData()
        {
            var employees = new Employee[1];
            employees[0] = new Employee { EmployeeId = "Ora-123", EmployeeName = "Benjamin Franklin", Designation = "Manager" };
            return new List<Employee>(employees);
        }

    }

}
