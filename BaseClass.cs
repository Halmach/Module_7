using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    public class BaseClass
    {
		public string Name;
		protected string Description;
		private int value;

		//public BaseClass()
		//{
		//	this.value = 0;
		//}

		public virtual void Display()
        {
			Console.WriteLine("Метод класса BaseClass");
        }

		public BaseClass(string name)
		{
			this.Name = name;
		}
	}

	public class InheritedClass : BaseClass
	{
		private int newValue;

		public InheritedClass() : base(100)
		{ }
		public InheritedClass(int newValue) :base("Vasya")
		{
			this.newValue = newValue;
		}
	}

}
