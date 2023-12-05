using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Indexer
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee(1226,"DP", 18000.00, "Developer", "MCB","Hyderabad");

            Console.WriteLine("===================Using string name====================");
            Console.WriteLine("================get===================");
            Console.WriteLine("Employee Id : " + emp["Eno"]);
            Console.WriteLine("Employee Name : " + emp["Ename"]);
            Console.WriteLine("Employee Salary : " + emp["Salary"]);
            Console.WriteLine("Employee Job : " + emp["Job"]);
            Console.WriteLine("Employee Department : " + emp["Dname"]);
            Console.WriteLine("Location : " + emp["Location"]);
            Console.WriteLine();

            emp["Eno"] = 2612;
            emp["Location"] = "Banglore";

            Console.WriteLine("================set===================");
            Console.WriteLine("Employee Id : " + emp["Eno"]);
            Console.WriteLine("Employee Name : " + emp["Ename"]);
            Console.WriteLine("Employee Salary : " + emp["Salary"]);
            Console.WriteLine("Employee Job : " + emp["Job"]);
            Console.WriteLine("Employee Department : " + emp["Dname"]);
            Console.WriteLine("Location : " + emp["Location"]);


            /*Console.WriteLine("===================Using Index====================");
            Console.WriteLine("================get===================");
            Console.WriteLine("Employee Id : " + emp[0]);
            Console.WriteLine("Employee Name : " + emp[1]);
            Console.WriteLine("Employee Salary : " + emp[2]);
            Console.WriteLine("Employee Job : " + emp[3]);
            Console.WriteLine("Employee Department : " + emp[4]);
            Console.WriteLine("Location : " + emp[5]);
            Console.WriteLine();

            emp[1] = "Durga Prasad";
            emp[2] = 20000.00;

            Console.WriteLine("================set===================");
            Console.WriteLine("Employee Id : " + emp[0]);
            Console.WriteLine("Employee Name : " + emp[1]);
            Console.WriteLine("Employee Salary : " + emp[2]);
            Console.WriteLine("Employee Job : " + emp[3]);
            Console.WriteLine("Employee Department : " + emp[4]);
            Console.WriteLine("Location : " + emp[5]);*/

            Console.ReadLine();
        }
    }
}
