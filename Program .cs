using System;
using Employee.Interfaces;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[2];
            employee[0] = new ContractualEmployee();
            employee[1] = new CasualEmployee();
            for (int i = 0; i < employee.Length; i++)
            {
                ((IProject)employee[i]).GetProjectDetails(1555);

            }

        }
    }
}
