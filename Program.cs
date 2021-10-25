using System;

namespace Module_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //InheritedClass b = new InheritedClass();

            //Console.WriteLine("Hello World!");
            BaseClass cl = new DerivedClass();
            ((DerivedClass)cl).Display();
     

        }
    }

    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager:Employee
    {
        public string ProjectName;
    }

    class Developer:Employee
    {
        string ProgrammingLanguage;
    }
}
