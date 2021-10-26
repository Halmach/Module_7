using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class Obj
    {
		private string name;
		public string Description;
		public static int MaxValue;
		public static string Parent;
		public static int DaysInWeek;
		private string owner;
		private int length;
		private int count;
		public int Value;

		static Obj()
        {
			MaxValue = 2000;
			DaysInWeek = 7;
			Parent = "System.Object";
		}

		public Obj()
		{ 
		}
		public Obj(string name, string ownerName, int objLength, int count)
		{
			this.name = name;
			owner = ownerName;
			length = objLength;
			this.count = count;
		}

		public static Obj operator +(Obj a, Obj b)
        {
			return new Obj
			{
				Value = a.Value + b.Value
			};
        }

		public static Obj operator -(Obj a,Obj b)
        {
			return new Obj
			{
				Value = a.Value - b.Value
			};
        }
	}
}
