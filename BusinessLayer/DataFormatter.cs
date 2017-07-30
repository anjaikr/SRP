using System;
using DataAccessLayer;

namespace BusinessLayer
{
    public class DataFormatter
    {
        public virtual string FormatEmployeeData()
        {
            var dataAccess = new DataAccess();
            Console.WriteLine("Getting Employee Data...");
            var employessList = dataAccess.GetEmployeeData();
            Console.WriteLine("Formatting the Employee details...");
            return string.Format("Employee Name of Employee ID {0} is {1}",
                                 employessList[0].EmployeeId, employessList[0].EmployeeName);
        }
    }
}