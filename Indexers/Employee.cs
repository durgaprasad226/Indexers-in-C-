using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Employee
    {
        int Eno;  //class members are private by default
        string Ename;//we cannot access them in other class
        double Salary; //If we make them public to access in other class everyone will access which is drawback
        string Job;  //properties-get, set access
        string Dname;  //Indexers- provides an access to access values using their index posotion
        string Location;

        public Employee(int Eno, string Ename, double Salary, string Job, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Salary = Salary;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;
        }

        public object this[string name]
        {
            get
            {
                /*if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return Salary;
                else if (index == 3)             //For indexes
                    return Job;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                return null;*/

                if (name.ToUpper() == "ENO")
                    return Eno;
                else if (name.ToUpper() == "ENAME")
                    return Ename;
                else if (name.ToUpper() == "SALARY")    //For strings
                    return Salary;
                else if (name.ToUpper() == "JOB")
                    return Job;
                else if (name.ToUpper() == "DNAME")
                    return Dname;
                else if (name.ToUpper() == "LOCATION")
                    return Location;
                return null;
            }

            set
            {
                /*if (index == 0)
                    Eno = (int)value;
                else if (index == 1)
                    Ename = (string)value;
                else if (index == 2)                //For indexes
                    Salary = (double)value;
                else if (index == 3)
                    Job = (string)value;
                else if (index == 4)
                    Dname = (string)value;
                else if (index == 5)
                    Location = (string)value;*/

                if (name.ToUpper() == "ENO")
                    Eno = (int)value;
                else if (name.ToUpper() == "ENAME")
                    Ename = (string)value;
                else if (name.ToUpper() == "SALARY")   //For strings
                    Salary = (double)value;
                else if (name.ToUpper() == "JOB")
                    Job = (string)value;
                else if (name.ToUpper() == "DNAME")
                    Dname = (string)value;
                else if (name.ToUpper() == "LOCATION")
                    Location = (string)value;
            }
        }
    }
}
