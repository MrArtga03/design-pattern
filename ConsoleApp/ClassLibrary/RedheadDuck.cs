using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public override string Display()
        {
            return "Display " + this.GetType();
        }

        public string Fly()
        {
            return "Fly RedheadDuck!";
        }

        public string Quack()
        {
            return "Quack RedheadDuck!";
        }
    }
}
