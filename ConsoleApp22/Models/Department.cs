using ConsoleApp22.Interfaces;
using ConsoleApp22.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Models
{
    class Department
    {
        public Employee[] Employees => _employees;
        public Employee[] _employees;
        
        

        public string Name { get; set; }
      

        public Employee Employee { get; set; }
        public double Average { get; set; }
        public double WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        public double salaryNow { get; set; }
        //public HumanResourcesManager Ortalama { get; set; }


        public Department(string name, double workerLimit, double salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
            _employees = new Employee[0];


        }
        public double CalcSalaryAverage()
        {
            double avarage = 0;
            double umumiMaas = 0;
            int count = 0;
            foreach (Employee item in Employees)
            {

                if (item.DepartmentName == Name)
                {
                    count++;
                    avarage = avarage + item.Salary;

                }
                umumiMaas = avarage / count;
            }

            return umumiMaas;
        }
       
        public override string ToString()
        {
            return $"Departmentin adi:{Name}\nIsci limiti :{WorkerLimit}\nMaas limiti:{SalaryLimit}";
        }

       


    }
}
