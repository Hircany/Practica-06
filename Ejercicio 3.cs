
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class A
    {
        public A()
        {
            Console.WriteLine("Constructor de la clase A");
        }
    }

    public class B : A 
    {
        public B()
        {
            Console.WriteLine("Constructor de la clase B");
        }
    }

    public class C : B
    {
        public C()
        {
            Console.WriteLine("Constructor de la clase C");
        }
    }

    class Pruebas
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
            Console.ReadKey();
        }
    }
}