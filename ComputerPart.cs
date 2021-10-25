using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor:ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Работает процессор");
        }

    }
    class MotherBoard:ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Работает материнская плата");
        }
    }

    class GraphicCard:ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Работает видеокарта");
        }
    }


}
