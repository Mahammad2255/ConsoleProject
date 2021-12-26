using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Models
{
    class Department
    {
        public string Name { get; set; }
        public double WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        public Department(string name, double workerLimit, double salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
        }


        public override string ToString()
        {
            return $"Departmentin adi:{Name}\nIsci limiti :{WorkerLimit}\nMaas limiti:{SalaryLimit}";
        }
        //public string[] Departments = { };

        //public Employee Employees { get; set; }


        //public void calcsalaryaverage(int salaryLimit )
        //{
        //    SalaryLimit = salaryLimit;

        //}

        //public Department(string name, double workerLimit, double salaryLimit/*, Employee employee*//*s*/)
        //{
        //    Name = name;
        //    WorkerLimit = workerLimit;
        //    SalaryLimit = salaryLimit;


        //}
        //public Department(string name, )
        //{

        //}



    }
}
