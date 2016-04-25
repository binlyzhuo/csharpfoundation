using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    public class AssemblyHelper
    {
        public static void ExecuteCodes()
        {
            // 
            Console.WriteLine(Assembly.GetExecutingAssembly().FullName);
        }
    }
}
