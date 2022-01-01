using ConsoleApp22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Employee
    {
       
        public string No { get; set; }
        
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string DepartmentName { get; set; }
        public double _salary { get; set; }
        public double AverageSalary { get; set; }
        //public Department[] DepartmentName { get; set; }

        public static int Count = 1000;
        //public int SalaryCount = 0;

        public Employee(string fullname, string position, double salary, string DepName)
        {
            Count++;


            No = DepName.Substring(0, 2).ToUpper() + Count;  // hr1001
            Fullname = fullname;
            Position = position;
            _salary = salary;
            AverageSalary = 0;
            //AverageSalary = salary+
           
           
            

           
            DepartmentName = DepName;


            //if (salary < 250)
            //{

            //}

        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value > 250)
                    _salary = value;
            }
        }


        public override string ToString()
        {
            return $"Nomresi: {No} Adi: {Fullname} Position: {Position} Maasi: {Salary} Departmenti: {DepartmentName }  ";
        }
    }
}