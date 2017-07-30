using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class OracleDataFormatter : DataFormatter
    {
        public override string FormatEmployeeData()
        {
            var dataAccess = new OracleDataAccess();
            Console.WriteLine("Getting Employee Data...");
            var employessList = dataAccess.GetEmployeeData();

            Console.WriteLine("Formatting the Employee details...");
            return string.Format("Employee Name of Employee ID {0} is {1} and Designation of the Employee is {2}",
            employessList[0].EmployeeId, employessList[0].EmployeeName, employessList[0].Designation);
        }
    }

}
