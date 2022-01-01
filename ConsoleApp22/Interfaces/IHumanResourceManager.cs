using ConsoleApp22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Interfaces
{
    interface IHumanResourceManager
    {
        Department[] Departments { get; }
        

        void AddDepartment(string name, double workerLimit, double salaryLimit /*Department Employees*/);
        //void GetDepartments(Department Departaments);
        void EditDepartments(string name, double workerLimit, double salaryLimit);
        void AddEmployee(string fullname, string position, double salary, string DepName);
        void RemoveEmployee(string DepName);

        void GetEmployeeByDepartment(string DepName);
        void ShowEmployee();
        void EditEmploye(string pos, double salary);
        
        
    }
}
