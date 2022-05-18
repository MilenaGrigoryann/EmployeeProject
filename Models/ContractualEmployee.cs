using System;
using Employee.Interfaces;

namespace Employee
{
    public class ContractualEmployee : Employee, IProject
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

    }
}
