using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    abstract class Car<TEngine> where TEngine: TypeEngine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart: CarComponent
        {

        }

    }


    class ElectricCar:Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }
    }

    class GasCar:Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
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
