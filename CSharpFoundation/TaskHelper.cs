using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    // http://blog.jobbole.com/85787/
    public class TaskHelper
    {
        public static void ExecuteCodes()
        {
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Task1 Start!!");

                Task task = Task.Run(() =>
                {
                   Thread.Sleep(500);
                    Console.WriteLine("Task2 start!!");
                });

                //task.Wait();
                Console.WriteLine("main thread complete!");
            });
        }

        public static void TestCodes()
        {
            for (int i = 0; i < 50; i++)
            {
                new Thread(DoRun1).Start();
            }

            for (int i = 0; i < 50; i++)
            {
                Task.Run(() =>
                {
                    DoRun2();
                });
            }
        }

        public static void TestTaskArgs()
        {
            Console.WriteLine("main thread start!");
            Task<string> task = Task<string>.Run(() =>
            {
                Thread.Sleep(1000);
                return Thread.CurrentThread.ManagedThreadId.ToString();
            });
            Console.WriteLine(task.Result);
            Console.WriteLine("main thread complete!");
        }

        public static void RunAsyncCode()
        {
            Console.WriteLine("main thread start");
            Task<int> task = GetLengthAsync();
            Console.WriteLine("main thread do something else");
            Console.WriteLine("task result:"+task.Result);
            Console.WriteLine("main thread end");
        }

        public static void CountPage()
        {
            Console.WriteLine("Get cnblogs.com");
            Task<int> task1 = CountCharAsync("http://www.cnblogs.com");
            Console.WriteLine("Get baidu.com");
            Task<int> task2 = CountCharAsync("http://www.baidu.com");
            Console.WriteLine("Do something else");
            Console.WriteLine("cnblosgs:{0}",task1.Result);
            Console.WriteLine("baidu:{0}",task2.Result);
        }

        static void DoRun1()
        {
            Console.WriteLine("Thread Id ="+Thread.CurrentThread.ManagedThreadId);
        }

        static void DoRun2()
        {
            Thread.Sleep(50);
            Console.WriteLine("Task call thread Id = "+Thread.CurrentThread.ManagedThreadId);
        }

        static Task<string> GetStringAsync()
        {
            return Task<string>.Run(() =>
            {
                Thread.Sleep(1000);
                return "finish";
            });
        }

        static async Task<int> GetLengthAsync()
        {
            Console.WriteLine("GetLengthAsync Start");
            //Task<int> task = Task<int>.Run(() =>
            //{
            //    string str = GetStringAsync().Result;
            //    return str.Length;
            //});
            //return task;
            string str = await GetStringAsync();
            Console.WriteLine("GetLengthAsync End");
            return str.Length;
        }

        static async Task<int> CountCharAsync(string url)
        {
            WebClient wc = new WebClient();
            string result = await wc.DownloadStringTaskAsync(new Uri(url));
            return result.Length;
        }
    }
}
