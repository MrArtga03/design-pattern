using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            RedheadDuck redheadDuck = new RedheadDuck();
            RubberDuck rubberDuck = new RubberDuck();
            DecoyDuck decoyDuck = new DecoyDuck();

            IFlyBehavior flyNoWay = new FlyNoWay();
            IQuackBehavior muteQuack = new MuteQuack();

            redheadDuck.SetFlyBehavior(flyNoWay);
            redheadDuck.SetQuackBehavior(muteQuack);

            Duck[] ducks = new Duck[] { 
                mallardDuck, 
                redheadDuck,
                rubberDuck, 
                decoyDuck 
            };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine(ducks[i].Fly());
                Console.WriteLine(ducks[i].Quack());

                Console.WriteLine("----");
            }

            Console.ReadKey();
        }
    }
}
