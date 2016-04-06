using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehavior
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
