using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1 : Interface1, Interface2
    {
        void A()
        {
            Console.WriteLine("A");
        }
        void B()
        {
            Console.Write("B");
        }
        public void M()
        {
            Console.WriteLine("M");
        }
        public void _A()
        {
            Console.WriteLine("_A");
        }
        public void _B()
        {
            Console.WriteLine("_B");
        }

        void Interface1.A()
        {
            throw new NotImplementedException();
        }

        void Interface1.B()
        {
            throw new NotImplementedException();
        }
        void Interface2._A()
        {
            throw new NotImplementedException();
        }

        void Interface2._B()
        {
            throw new NotImplementedException();
        }
        void Interface1.C()
        {
            Console.WriteLine("1C");
        }

        void Interface2.C()
        {
            Console.WriteLine("2C");
        }
    }
}
