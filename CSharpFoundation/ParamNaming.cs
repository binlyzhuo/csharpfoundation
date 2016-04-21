using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    public class ParamNaming
    {
        static void Dump(int x, int y=20, int z=30)
        {
            Console.WriteLine("X={0},y={1},z={2}",x,y,z);
        }

        public static void ExecuteCode()
        {
            Dump(1,z:10,y:11);

            Dump(x:Log(1),y:Log(2),z:Log(3));
            Dump(z:Log(3),x:Log(1),y:Log(2));

            Dump(10,z:31);
        }

        static int Log(int value)
        {
            Console.WriteLine("Log:{0}",value);
            return value;
        }

        static void AppendTimespan(string fileName, string message, Encoding encoding = null, DateTime? timespan = null)
        {
            
        }
    }
}
