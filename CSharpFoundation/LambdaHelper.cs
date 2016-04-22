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
            del myDel = x => x*x;
            int j = myDel(5);
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
