using System;
using System.Collections.Generic;

//Delegate is a type safe function pointer
namespace Delegates
{
    //Initialise a delegate like a function
    public delegate void TypeHelloDelegate(string Name);
    public delegate bool PromotionEligible(Employee employee);
    public class Program
    {
        public static void Main(string[] args)
        {
            TypeHelloDelegate del = new TypeHelloDelegate(TypeHello);//Create instance of a delegate like a class
            del("Ujjwal");




            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { name = "Ujjwal", age = 28, exp = 4 });
            empList.Add(new Employee() { name = "Ankur", age = 27, exp = 6 });
            empList.Add(new Employee() { name = "Faizal", age = 28, exp = 6 });
            empList.Add(new Employee() { name = "Manu", age = 32, exp = 8 });
            empList.Add(new Employee() { name = "Shubha", age = 17, exp = 0 });

            PromotionEligible delPromotionEligibleAge = new PromotionEligible(PromotionAge);
            PromoteEmployee(empList, delPromotionEligibleAge);

            PromotionEligible delPromotionEligibleExp = new PromotionEligible(PromotionExperience);
            //PromoteEmployee(empList, delPromotionEligibleExp);



            Console.ReadLine();
        }
        public static void TypeHello(string Name)
        {
            Console.WriteLine("Hello "+ Name +"\n");
        }

        //Framework class - no hard coded logic
        public static void PromoteEmployee(List<Employee> employeeList, PromotionEligible promotionEligible)
        {
            foreach (Employee employee in employeeList)
            {
                if (promotionEligible(employee))
                {
                    Console.WriteLine(employee.name + " is promoted.");
                }
                else
                {
                    Console.WriteLine(employee.name + " is not promoted.");
                }
            }
        }
        public static bool PromotionAge(Employee employee)
        {
            if (employee.age >=28)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PromotionExperience(Employee employee)
        {
            if (employee.exp >=5)
            {
                return true;
            }
            else
            {
                return true;
            }
        }        
                
    }
    public class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public int exp { get; set; }
    }

}
