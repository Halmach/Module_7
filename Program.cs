using System;

namespace Module_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //InheritedClass b = new InheritedClass();

            //Console.WriteLine("Hello World!");
            //BaseClass cl = new DerivedClass();
            //((DerivedClass)cl).Display();
            var str = "Good buy";
            Console.WriteLine("0 " + str);
            ChangeString(str);
            Console.WriteLine("2 " + str);


            ProjectManager obj = new ProjectManager();

            if (obj is Employee)
            {
                Console.WriteLine("Объект класса Animal");
            }
        }


        static void ChangeString(string  str)
        {
            str = "Hello";
            Console.WriteLine(str);
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
