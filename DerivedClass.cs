﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class DerivedClass : BaseClass
    {
        public int Counter;
        public DerivedClass(string name,string description):base(name)
        {
            this.Description = description;
        }

        public DerivedClass(string name, string description, int counter):this(name,description)
        {
            Counter = counter;
            
        }
    }
}
