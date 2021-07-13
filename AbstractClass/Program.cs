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
            ChildClass c1 = new ChildClass();//instantiates 0 para(default) ctor of childclass which in turn instantiate 0 para(Default) ctor of base class
            c1.TestMethod();
            ChildClass c2 = new ChildClass("Ujjwal", 27);//instantiate 2 para ctor of childclass which in turn instantiate 0 para(Default) ctor of base class
            ChildClass c3 = new ChildClass("ankur", 26,"Data scientist");//instantiates 3 para ctor of childclass which in turn instantiates 2 para ctor of base class
            Console.ReadLine();
        
        }
        public class ChildClass : BaseClass
        {
            public ChildClass() : base("Faisal", 27) { }//write like this if you want to explicitly call a ctor with mismatched argument
            public ChildClass(string name, int age) { }
            public ChildClass(string name, int age , string profession) : base(name.ToUpper(), age) { }
            public override void TestMethod()
            {
                Console.WriteLine("Hello from the overriden test method.");
            }
        }

    }
}
