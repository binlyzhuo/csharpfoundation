using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    public class DLRHelper
    {
        public static void ExecuteCode()
        {
            var staticPerson = new Person();
            dynamic dynamicPerson = new Person();

            staticPerson.GetFullName("John", "Smith");
            dynamicPerson.GetFullName("John", "Smith");

            // execute the coding
            // dynamic the person 
            dynamic dyn = 100;
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(dyn);
            dyn = "this is a string";
            Console.WriteLine(dyn);
            dyn = new Person() { FirstName = "Zhuo", LastName = "Bin" };
            Console.WriteLine(dyn.GetType());
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetFullName(string firstName, string lastName)
        {
            Console.WriteLine(string.Concat(firstName, " ", lastName));
        }
    }

    //===

    public class StaticClass
    {
        public int IntValue  = 100;
    }

    public class DynamicClass
    {
        public dynamic DynInt = 100;
    }
}
