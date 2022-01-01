using ConsoleApp22.Interfaces;
using ConsoleApp22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Services
{
    class HumanResourcesManager : IHumanResourceManager
    {

       

        public Department[] Departments => _departments;
        public Department[] _departments;
        //public void AddDepartment(Department Name, Department WorkerLimit, Department SalaryLimits, Department Employees)
        //{
        //    Department department = new Department()
        //}
        
        public HumanResourcesManager()
        {
            _departments = new Department[0];
           

        }
        

        public void AddDepartment(string name, double workerLimit, double salaryLimit)
        {
            Department department = new Department(name, workerLimit, salaryLimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;
        }


        //public void AddDepartment(string name, double workerLimit, double salaryLimit)
        //{
        //    Department department = new Department(name, workerLimit, salaryLimit);
        //    Array.Resize(ref _departments, _departments.Length + 1);
        //    _departments[_departments.Length - 1] = department;
        //}

        public void AddEmployee(/*string no,*/ string fullname, string position, double salary, string DepName)
        {
            foreach (Department item in Departments)
            {
                if(item.Employees!=null && item.Name.ToLower() == DepName.ToLower())
                {
                    Employee employee = new Employee(fullname, position, salary, DepName);
                    Array.Resize(ref item._employees, item._employees.Length + 1);
                    item._employees[item._employees.Length - 1] = employee;
                    break;
                }
            }
        }
           
        

        public void EditDepartments(string name, double workerLimit, double salaryLimit)
        {
            //Department department = null;

            //foreach (Department item in _departments)
            //{
            //    if (item.Name == name)
            //    {
            //        department = item;
            //        break;
            //    }
            //}

            //department.Name = name;
            ////department.WorkerLimit= workerLimit;
            ////department.SalaryLimit= salaryLimit;
        }


        public void EditEmploye(string pos, double salary)
        {
            //Employee employe = null;

            //foreach (Employee item in _employees)
            //{
            //    if (item.Position == pos)
            //    {
            //        employe = item;
            //        break;
            //    }
            //}
            //foreach (Employee item in _employees)
            //{
            //    if (item.Salary == salary)
            //    {
            //        employe = item;
            //        break;
            //    }
            //}

            //employe.Position = pos;
            //employe.Salary = salary;


        }

        public void GetDepartments(Department Departaments)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(string isci)
        {
            foreach (Department item in Departments)
            {
                for (int i = 0; i < item._employees.Length; i++)
                {
                    if (item.Employees[i] != null && item._employees[i].No == isci)
                    {

                        item._employees[i] = null;
                        return;
                        
                    }
                }
            }
           
        }

        public void ShowEmployee()
        {
            throw new NotImplementedException();
        }

        public void GetEmployeeByDepartment(string depNameIs)
        {
            foreach (Department item in Departments)
            {
                if (item.Name.ToLower() == depNameIs.ToLower())
                {
                    foreach (Employee item2 in item.Employees)
                    {
                        if (depNameIs.ToLower() == item2.DepartmentName.ToLower())
                        {
                            
                                Console.WriteLine(item2);
                            
                        }

                       

                    }
                }
                

            }

        }

      
    }
}
