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

        public static void ExecuteCodes()
        {
            Console.WriteLine("main thread start!");
            Thread t1 = new Thread(DoRun1);
            t1.Start();

            Thread t2 = new Thread(DoRun2)
            {
                IsBackground = true
            };

            Console.WriteLine("main thread complete!");
        }

        static void DoRun1()
        {
            Thread.Sleep(500);
            Console.WriteLine("UI Thread!");
        }

        static void DoRun2()
        {
            Thread.Sleep(1500);
            Console.WriteLine("Background Thread!");
        }
    }
}
