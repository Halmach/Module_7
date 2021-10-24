using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class DerivedClass : BaseClass
    {
        private int counter;

        public override int Counter
        {
            get { return counter; }
            set { if (value >= 0) counter = value; }
        }

        public DerivedClass()
        {

        }
        public DerivedClass(string name,string description):base(name)
        {
            this.Description = description;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");

        }
        public DerivedClass(string name, string description, int counter):this(name,description)
        {
            this.counter = counter;
            
        }
    }
}
