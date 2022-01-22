using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "Хлоп хлоп хлоп";
        }
    }
}
