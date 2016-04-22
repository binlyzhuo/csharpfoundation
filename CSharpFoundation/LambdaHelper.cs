using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    public class LambdaHelper
    {
        private delegate int del(int i);

        public static void ExecuteCodes()
        {
            List<People> people = new List<People>();
            var p1 = new People(21, "p1");
            var p2 = new People(22, "p2");
            var p3 = new People(23, "p3");
            var p4 = new People(24, "p4");

            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);

            var result = people.Where(delegate(People p) { return p.Age > 20; });
            var result2 = people.Where(p => p.Age > 20);
            Func<People, bool> search = delegate(People p) { return p.Age>20; };
            var result3 = people.Where(search);

            //==============
            //
        }

        public static void FindList()
        {
            List<string> list = new List<string>();
            list.AddRange(new string[] { "ASP.NET课程", "J2EE课程", "PHP课程", "数据结构课程" });
            Predicate<string> findPredicate = new Predicate<string>(IsBookCategory);
            List<string> bookCategory = list.FindAll(findPredicate);
            foreach (var s in bookCategory)
            {
                Console.WriteLine("{0}\t",s);
            }
        }

        static bool IsBookCategory(string str)
        {
            return str.EndsWith("课程");
        }


    }

    public class People
    {
        public int Age { set; get; }
        public string Name { set; get; }

        public People(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
