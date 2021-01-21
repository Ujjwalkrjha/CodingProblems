using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //var key = (Console.ReadLine()[0]).ToString();
            Customer[] c1 = new Customer[4];

            //List<Customer> c2 = new List<Customer>();
            //Customer ctest = new Customer();
            //Customer ctest1 = new Customer();
            //Customer ctest2 = new Customer();

            //ctest.name = "ujjwal";
            //ctest.gender = Gender.Male;
            //c2.Add(ctest);

            //ctest1.name = "Ankur";
            //ctest1.gender = Gender.Male;
            //c2.Add(ctest1);

            //ctest2.name = "Shubha";
            //ctest2.gender = Gender.Female;
            //c2.Add(ctest2);

            c1[0] = new Customer
            {
                name = "Ujjwal",
                gender = Gender.Male
            };
            c1[1] = new Customer
            {
                name = "Ankur",
                gender = Gender.Male
            };
            c1[2] = new Customer
            {
                name = "Shubha",
                gender = Gender.Female
            };
            c1[3] = new Customer
            {
                name = "Test",
                gender = Gender.Unkown
            };
            foreach (Customer customer in c1)
            {
                Console.WriteLine("Name = {0} And Gender = {1}", customer.name, GetGender(customer.gender));

            }
            Console.ReadLine();



        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unkown:
                    return "Unknown";

                case Gender.Male:
                    return "Man";

                case Gender.Female:
                    return "Woman";
                default:
                    return "Invalid Data";
            }
        }
    }


    public enum Gender
    {
        //0,1,2 values for Gender
        Unkown,
        Male,
        Female
    }
    public class Customer
    {
        public string name;
        public Gender gender;
    }
}