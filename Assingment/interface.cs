using System;
using System;

namespace PrintableInterface
{
    interface Iprintable
    {
        void print();

    }
    class Employee : Iprintable
    {
        int EmpID;
        string Empname;
        public Employee(int Empid, string empname)
        {
            this.EmpID = Empid;
            this.Empname = empname;

        }
        public void print()
        {
            Console.Write("Employee ID" + EmpID + "Employee Name " + Empname);
        }

    }
    class Student : Iprintable
    {
        int StudentID;
        string StudentName;


        public Student(int StudentID, string StudentName)
        {
            this.StudentID = StudentID;
            this.StudentName = StudentName;
        }
        public void print()
        {
            Console.WriteLine("Student id= " + StudentID + "Student Name =" + StudentName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Iprintable ip = new Employee(1, "Ganesh");
            ip.print();


            Iprintable ipt = new Student(10, "Vishal");
            ipt.print();
        }


    }
}



    
    
       
        
          
       
   
