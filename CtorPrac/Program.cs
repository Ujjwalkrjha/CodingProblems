using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //child childObj = new child();
            Base.rate = 25;
            Base.incrementrate();
            Console.WriteLine("The rate is {0}",Base.rate);
            Console.ReadLine();
        }
        
           
    //class child
    //    {
    //        public child() : base()
    //        {
    //            Console.WriteLine("hello child ctor");
    //            Console.ReadLine();

    //        }


    //    }
    }




    class Base
    {
        //public Base()
        //{
        //    Console.WriteLine("Hello parent ctor with no arguments...");
            
        //}
        private Base(string a)
        {
            Console.WriteLine(a);
            Console.WriteLine("Hello from priv ctor...");
            
        }
        public static int rate;
        public static int incrementrate()
        {
            return ++rate;
        }
    }

}
