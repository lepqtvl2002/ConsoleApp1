using System;

namespace ConsoleApp1
{ 
    class Program
    {
        static void Main(String[] args)
        {
        Class1 class1 = new Class1();
        class1.M();
        Interface1 interface1 = (Interface1) class1;
            interface1.C();
        Interface2 interface2 = (Interface2) class1;
            interface2.C();
        }
    }
}