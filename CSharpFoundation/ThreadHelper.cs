using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    public class ThreadHelper
    {
        static void GetThreadInfo()
        {
            Thread thread = new Thread(Work);
            thread.IsBackground = true;

            ThreadPool.QueueUserWorkItem(Work, "");
        }

        static void Work(object stat)
        {
            Console.WriteLine("I am working");
        }
    }
}
