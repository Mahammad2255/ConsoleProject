using ConsoleApp22.Models;
using ConsoleApp22.Services;
using System;

namespace ConsoleApp22
    
{
    

    class Program

    {
        
        static void Main(string[] args)
        {

            HumanResourcesManager humanResourcesManager = new HumanResourcesManager();
            

            do
            {
                Console.WriteLine("-------------------- Human Resource Management  --------------------");
                
                Console.WriteLine("1: Departameantlerin siyahisini gostermek");
                Console.WriteLine("2: Departamenet yaratmaq");
                Console.WriteLine("3: Departamenetde deyisiklik et");
                Console.WriteLine("4: Departamentdeki iscilerin siyahisini goster");
                Console.WriteLine("5: Isci elave et");
                Console.WriteLine("6: Iscilerin siyahisini gostermek");
                Console.WriteLine("7: Isciler uzerinde deyisiklik");
                Console.WriteLine("8: Iscileri silme");
                Console.Write("\nEmeliyyatin nomresini daxil edin: ");

                string choose = Console.ReadLine();
                int chooseNum;
                int.TryParse(choose, out chooseNum);
                switch (chooseNum)
                {
                    case 1:
                        Console.Clear();
                        ShowAllList(ref humanResourcesManager);
                        break;
                    case 2:
                        Console.Clear();
                        AddDepartmen(ref humanResourcesManager);
                        break;
                    case 3:
                        Console.Clear();
                        EditDepartments(ref humanResourcesManager);
                        break;
                    case 4:
                        Console.Clear();
                        GetEmployeeByDepartment(ref humanResourcesManager);
                        break;
                    case 5:
                        Console.Clear();
                        AddEmployee(ref humanResourcesManager);
                        break;
                    case 6:
                        Console.Clear();
                        ShowEmpList(ref humanResourcesManager);
                        break;
                    case 7:
                        Console.Clear();
                        EditEmployee(ref humanResourcesManager);
                        break;
                    case 8:
                        Console.Clear();
                        RemoveEmployee(ref humanResourcesManager);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun Daxil Et");
                        break;
                }

            } while (true);

        }

        public static void EditDepartments(ref HumanResourcesManager humanResourcesManager)
        {
            if (humanResourcesManager.Departments.Length <= 0)
            {
                Console.WriteLine("Siyahi Bosdur. Once Daxil Edin");
                return;
            }

            foreach (Department item in humanResourcesManager.Departments)
            {
                Console.WriteLine(item);
                Console.WriteLine("------------------------------------");
            }

            Console.Write("Duzelis Etmek Isdediyniz Departamentin adini Daxil Et: ");
            string depName = Console.ReadLine();
            bool checkDepName = true;
            int count = 0;
        start:
            while (checkDepName)
            {
                foreach (Department item in humanResourcesManager.Departments)
                {
                    if (item.Name.ToLower() == depName.ToLower())
                    {
                        count++;
                    }
                }

                if (count <= 0)
                {
                    Console.WriteLine("Daxil Etdiyniz adda department yoxdur");
                    Console.Write("Duzgun Departament adi Daxil Et: ");
                    depName = Console.ReadLine();
                    goto start;
                }

                else
                {
                    checkDepName = false;

                }
                count = 0;




                Console.Write("Yeni departament adi daxil edin: ");
                string nameE = Console.ReadLine();


                while (nameE.Length! < 2)
                {
                    Console.WriteLine("Departamentin adi 2 herfden az ola bilmez:");
                    nameE = Console.ReadLine();
                }

                foreach (Department item in humanResourcesManager.Departments)
                {
                    if (item.Name.ToLower() == depName.ToLower())
                    {
                        item.Name = nameE;
                    }


                }
              

            }




        }

        static void ShowAllList(ref HumanResourcesManager humanResourcesManager)
        {
            if (humanResourcesManager.Departments.Length <= 0)
            {
                Console.WriteLine("Siyahi bosdur, evvelce daxil edin.");
                return;

            }
            foreach (Department item in humanResourcesManager.Departments)
            {
                Console.WriteLine(item);
                //Console.WriteLine(item.CalcSalaryAverage());
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Maas ortalamasi : ");
                Console.WriteLine(item.CalcSalaryAverage());
            }
          

           

        }
        static void ShowEmpList(ref HumanResourcesManager humanResourcesManager)
        {
           
            foreach (Department item in humanResourcesManager.Departments)
            {
                if (item.Employees.Length <= 0)
                {
                    Console.WriteLine("Siyahi bosdur, evvelce daxil edin.");
                    return;

                }

                foreach (Employee item2 in item.Employees)
                {
                    Console.WriteLine(item2);
                    Console.WriteLine("-------------------------------------------------");
                }
            }
            
            
        }
        static void AddDepartmen(ref HumanResourcesManager humanResourcesManager)
        {
            Console.Write("Elave edeceyiniz Departmenti daxil edin: ");
            string name = Console.ReadLine();
            bool chechName = true;
            int count = 0;

            while (chechName)
            {
                foreach (Department item in humanResourcesManager.Departments)
                {
                    if (item.Name.ToLower() == name.ToLower())
                    {
                        count++;
                    }
                }


                if (count > 0)
                {
                    Console.WriteLine("Daxil etdiyiniz departman artiq movcuddur");
                    Console.Write("Duzgun daxil edin: ");
                    name = Console.ReadLine();
                }
                else
                {
                    chechName = false;
                }
                count = 0;
            }

            Console.Write("Isci sayini daxil edin: ");
            string workerLimit = Console.ReadLine();
            double workekNum;

            while (!double.TryParse(workerLimit, out workekNum) || workekNum < 1)
            {
                Console.Write("Duzgun Say Daxil Et: ");
                workerLimit = Console.ReadLine();
            }

            Console.Write("Salary Limiti daxil edin: ");
            string salaryLimit = Console.ReadLine();
            double salaryNum;

            while (!double.TryParse(salaryLimit, out salaryNum) || salaryNum < 250)
            {
                Console.Write("Duzgun Salary Daxil Et: ");
                salaryLimit = Console.ReadLine();

            }

            humanResourcesManager.AddDepartment(name, workekNum, salaryNum);

        }
        //static int workerCount = 0;
        static void AddEmployee(ref HumanResourcesManager humanResourcesManager)
        {
            
            //double workerLimit=0;

            if (humanResourcesManager.Departments.Length <= 0)
            {
                Console.Write("Evvelce department yaradin.");
                return;

            }

            //Start:

            Console.Write("Elave edeceyiniz Iscinin adini daxil edin: ");
            string name = Console.ReadLine();



            Console.Write("Isci Positionunu daxil edin: ");
            string workerPos = Console.ReadLine();


            while (workerPos.Length! < 2)
            {
                Console.Write("Position adi 2 herfden az olmamalidir: ");
                workerPos = Console.ReadLine();
            }

            Console.Write("Salary daxil edin");
            string salary = Console.ReadLine();
            double salaryNum;


            while (!double.TryParse(salary, out salaryNum) || salaryNum < 250)
            {
                Console.Write("Duzgun Salary Daxil Et: ");
                salary = Console.ReadLine();

            }
            
            Console.Write("Elave edeceyiniz Departmenti daxil edin: ");
            string nameDep = Console.ReadLine();
            bool chechNameD = true;
            int countCheck = 0;


            while (chechNameD)
            {
                foreach (Department item in humanResourcesManager.Departments)
                {
                    if (nameDep == item.Name)
                    {
                        countCheck++;
                    }

                }

                if (countCheck <= 0)
                {
                    Console.WriteLine("Bu departament movcud deyil");
                    Console.Write("Duzgun daxil edin: ");
                    nameDep = Console.ReadLine();

                }
                else
                {

                    chechNameD = false;
                }
                countCheck = 0;

             
                foreach (Department item in humanResourcesManager.Departments)
                {
                    if(nameDep == item.Name && item.WorkerLimit-1 < item.Employees.Length)
                    {
                      
                            Console.WriteLine("Bu department uzre isci limitini kecmek olmaz. \n Basqa departament yoxlayin");
                        return;
                       
                      
                        
                    }
                    
                   
                }
                

                foreach (Department item in humanResourcesManager.Departments)
                {

                    foreach (Employee item2 in item.Employees)
                    {
                        if (nameDep == item.Name)
                        {
                            double umumiMaas = 0;
                            umumiMaas = umumiMaas + item2.Salary;
                            if (umumiMaas > item.SalaryLimit)
                            {
                                Console.WriteLine("Isciye ayliq verile bilecek maasin limitini kecdiz tekrar yoxlayin");
                                return;
                            }
                        }
                        

                    }
                    
                }



                
            }
            humanResourcesManager.AddEmployee(name, workerPos, salaryNum, nameDep);

            double umumimaas = 0;
            foreach (Department item in humanResourcesManager.Departments)
            {

                foreach (Employee item2 in item.Employees)
                {

                    if (nameDep == item.Name)
                    {

                        umumimaas = umumimaas + item2.Salary;

                    }
                    if (umumimaas > item.SalaryLimit)
                    {
                        Console.WriteLine("isci maas limit kecdiniz");

                    }
                }
            }

        }
       
        static void GetEmployeeByDepartment(ref HumanResourcesManager humanResourcesManager)
        {
            if (humanResourcesManager.Departments.Length <= 0)
            {
                Console.WriteLine("Department movcud deyil, evvelce department yaradin");
                return;

            }

            Console.Write("Departament adi daxil edin: ");
            string depNameIs = Console.ReadLine();
            foreach (Department item in humanResourcesManager.Departments)
            {
                if(depNameIs.ToLower() == item.Name.ToLower())
                {
                     if(item.Employees.Length <= 0)
                    {
                        Console.WriteLine($"{depNameIs} departamenti movcuddur, lakin bu departamende isci yoxdur");
                        return;
                    }

                }
                //foreach (Employee item2 in item.Employees)
                //{
                //    if(depNameIs ==)
                //}
            }
            humanResourcesManager.GetEmployeeByDepartment(depNameIs);








            //foreach (Department item in humanResourcesManager.Departments)
            //{

            //    while (CheckTrue)
            //    { 
            //        if(item.Name != depNameIs)
            //        {
            //            Console.WriteLine("Bu adda departament yoxdur, duzgun daxil edin");
            //            depNameIs = Console.ReadLine();


            //        }
            //        else
            //        {
            //            CheckTrue = false;
            //        }

            //    }
            //    humanResourcesManager.GetEmployeeByDepartment(depNameIs);
            //}



        }
        static void EditEmployee(ref HumanResourcesManager humanResourcesManager)
        {
            Console.Write("Duzelis Etmek Isdediyniz Iscinin Nomresini Daxil Et: ");
            string empName = Console.ReadLine();
            bool checkEmpName = true;
            int count = 0;
        start:
            while (checkEmpName)
            {

                foreach (Department item in humanResourcesManager.Departments)
                {
                    foreach (Employee item2 in item.Employees)
                    {
                        if(item2.No.ToLower() == empName.ToLower())
                        {
                            count++;
                        }
                    }
                }
                //foreach (Employee item in humanResourcesManager.Employees)
                //{
                //    if (item.No.ToLower() == empName.ToLower())
                //    {
                //        count++;
                //    }
                //}

                if (count <= 0)
                {
                    Console.WriteLine("Daxil Etdiyniz adda isci nomresi yoxdur");
                    Console.Write("Duzgun Isci nomresi Daxil Et: ");
                    empName = Console.ReadLine();
                    goto start;
                }

                else
                {
                    checkEmpName = false;

                }
                count = 0;




                Console.Write("Yeni isci vezifesi daxil edin: ");
                string namePos = Console.ReadLine();


                while (namePos.Length! < 2)
                {
                    Console.WriteLine("Isci vezifesi 2 herfden az ola bilmez: ");
                    namePos = Console.ReadLine();
                }

                foreach (Department item in humanResourcesManager.Departments)
                {
                    foreach (Employee item2 in item.Employees)
                    {
                        if(item2.No.ToLower() == empName)
                        {
                            item2.Position = namePos;
                        }
                    }
                }
                //foreach (Employee item in humanResourcesManager.Employees)
                //{
                //    if (item.No.ToLower() == empName)
                //    {
                //        item.Position = namePos;
                //    }


                //}
                Console.Write("Yeni isci salary daxil edin: ");
                string nameSal = Console.ReadLine();
                int nameSalary;
                int.TryParse(nameSal, out nameSalary);

                while (nameSalary < 250)
                {
                    Console.WriteLine("Isci maasi 250-den  az ola bilmez: ");
                    nameSal = Console.ReadLine();
                }

                foreach (Department item in humanResourcesManager.Departments)
                {
                    foreach (Employee item2 in item.Employees)
                    {
                        if(item2.No.ToLower() == empName)
                        {
                            item2.Salary = nameSalary;
                        }
                    }
                }

                //foreach (Employee item in humanResourcesManager.Employees)
                //{
                //    if (item.No.ToLower() == empName)
                //    {
                //        item.Salary = nameSalary;
                //    }


                //}



            }
        }
        static void RemoveEmployee(ref HumanResourcesManager humanResourcesManager) 
        {

            foreach (Department item in humanResourcesManager.Departments)
            {
                foreach (Employee item2 in item.Employees)
                {
                    if(item2 != null)
                    {
                        Console.WriteLine(item2);
                    }
                }
            }
            //foreach (Employee item in humanResourcesManager.Employees)
            //{
            //    if (item != null)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            Console.Write("Silmek istediyiniz iscinin nomresini daxil edin: ");
        checkNo:
            string iscniNo = Console.ReadLine();
            bool checkEmpNo = true;
            int count = 0;
            while (checkEmpNo)
            {
                foreach (Department item in humanResourcesManager.Departments)
                {
                    foreach (Employee item2 in item.Employees)
                    {
                        if (item2.No == iscniNo)
                        {
                            count++;
                        }
                    }
                }
                //foreach (Employee item in humanResourcesManager.Employees)
                //{
                //if (item.No == iscniNo)
                //{
                //    count++;
                //}
                //}
                if (count <= 0)
                {
                    Console.WriteLine("Bele bir isci movcud deyil");
                    Console.Write("Duzgun isci nomresi daxil edin: ");
                    goto checkNo;
                }
                else
                {
                    checkEmpNo = false;


                }
                count = 0;
                humanResourcesManager.RemoveEmployee(iscniNo);

            }
        }
        static void Ortalama(ref HumanResourcesManager humanResourcesManager)
        {
            
        }

        

    }
    }
