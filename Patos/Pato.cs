using Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos
{
    public abstract class Pato
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

       
        public Pato(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public abstract void display();
        public void performFly()
        {
            _flyBehavior.fly();
        }
        public void performQuack()
        {
            _quackBehavior.Quack();
        }
        public void swim()
        {
            Console.WriteLine("Todos nadamos, hasta los de decoración");
        }

    }
}
