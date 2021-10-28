using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class Car<T1> where T1: TypeEngine
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart) where T2: CarComponent
        {

        }

    }


    abstract class TypeEngine
    {

    }
    class ElectricEngine : TypeEngine
    {

    }

    class GasEngine : TypeEngine
    {

    }

    abstract class CarComponent
    {

    }

    class Battery : CarComponent
    {

    }

    class Differential : CarComponent
    {

    }

    class Wheel : CarComponent
    {

    }


}
