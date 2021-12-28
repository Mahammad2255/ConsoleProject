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
        public string Name { get; set; }
        public Employee Employee { get; set; }
        public double Average { get; set; }
        public double WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        //public HumanResourcesManager Ortalama { get; set; }

        
        public Department(string name, double workerLimit, double salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
             

        }

        //public double CalcSalaryAverage()
        //{
        //    double result = 0;
        //    int count = 0;
        //    foreach (var item in Ortalama.Employees)
        //    {
               
                
        //        for (int i = 0; i < item.No.Length; i++)
        //        {
        //            if(item.DepartmentName[i] == item.DepartmentName[i+1])
        //            {
        //                count++;
        //                result = item.Salary / count;
        //            }
        //        }

              

        //    }

        //    return result;
        //}


        public override string ToString()
        {
            return $"Departmentin adi:{Name}\nIsci limiti :{WorkerLimit}\nMaas limiti:{SalaryLimit}";
        }

        //public override double CalcSalaryAverage()
        //{
        //    return: { Average}
        //}



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
