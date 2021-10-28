using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class Car<TEngine> where TEngine: TypeEngine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart: CarComponent
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
