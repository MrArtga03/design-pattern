using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override string Display()
        {
            return "Display " + this.GetType();
        }

        public string Fly()
        {
            return "Fly MallardDuck!";
        }

        public string Quack()
        {
            return "Quack MallardDuck!";
        }
    }
}
