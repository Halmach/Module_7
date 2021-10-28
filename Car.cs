using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class Car<T1>
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart)
        {

        }

    }

    class ElectricEngine
    {

    }

    class GasEngine
    {

    }

    class Battery
    {

    }

    class Differential
    {

    }

    class Wheel
    {

    }


}
