using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class Helper
    {
        public static void Swap(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
