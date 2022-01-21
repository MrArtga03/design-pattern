using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract public class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public string Swim()
        {
            return "Буль буль буль ";
        }

        public string Display()
        {
            return this.GetType() + " " + this.flyBehavior + " " + this.quackBehavior;
        }

        public string Fly()
        {
            return flyBehavior.Fly();
        }

        public string Quack()
        {
            return quackBehavior.Quack();
        }
    }
}
