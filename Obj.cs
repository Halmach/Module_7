using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class Obj
    {
		private string name;
		private string owner;
		private int length;
		private int count;
		public int Value;


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
