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

            Duck[] ducks = new Duck[] { mallardDuck, redheadDuck };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine(ducks[i].Swim());
            }

            RubberDuck rubberDuck = new RubberDuck();
            Console.WriteLine(rubberDuck.Quack());

            Console.ReadKey();
        }
    }
}
