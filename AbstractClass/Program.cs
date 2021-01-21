using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{

    public abstract class BaseClass
    {
        private string name;
        private int age;
        public BaseClass()
        {
            Console.WriteLine("Hello from the 0 argument base class constructor");
        }
        public BaseClass(string _name, int _age)
        {
            name = _name;
            age = _age;
            Console.WriteLine("Hello from the 2 argument Base Constructor");
            Console.WriteLine("This constructor is invoked by {0} whose age is {1}.",name,age);
        }
        public virtual void TestMethod()
        {
            Console.WriteLine("Hello fromt the test method");
        }
    }
    public class Program
    {
        static void Main()
        {
            ChildClass c1 = new ChildClass();
            c1.TestMethod();
            ChildClass c2 = new ChildClass("ankur", 26);
            Console.ReadLine();
        
        }
        public class ChildClass : BaseClass
        {
            public ChildClass() { }
            public ChildClass(string name,int age) : base(name, age) { }
            public override void TestMethod()
            {
                Console.WriteLine("Hello from the overriden test method.");
            }
        }

    }
}
