using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    public class ThreadPoolHelper
    {
        //http://www.tuicool.com/articles/6vMFza
        public static void ExecuteCode()
        {
            Console.WriteLine("main thread start");
            ThreadPool.QueueUserWorkItem((o) =>
            {
                //Console.WriteLine(o.GetType());
                //o = new object();
                Console.WriteLine(DateTime.Now);
            });
            Thread.Sleep(1000);
            Console.WriteLine("main next......");
        }
    }
}
