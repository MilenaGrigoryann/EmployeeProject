using System;
using Employee.Interfaces;

namespace Employee
{
    public class CasualEmployee : Employee, IProject, IEmployee
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }
}
