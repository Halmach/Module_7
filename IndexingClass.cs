using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class IndexingClass
    {
        private int[] array;

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < array.Length) return array[i];
                else return -1;
            }
            set
            {
                array[i] = value;
            }
        }
        public IndexingClass(int[] array)
        {
            this.array = array;
        }
       
    }
}
