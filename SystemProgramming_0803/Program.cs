using System;
using System.Threading;

namespace SystemProgramming_0803
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Thread Join

            //Console.WriteLine("Before Thread Start");
            //Thread th = new Thread(() =>
            //{
            //    Console.WriteLine("Thread Start");
            //    for (int i = 0; i < 2000; i++)
            //    {
            //        Console.WriteLine($"Thread num {i}");
            //    }
            //    Console.WriteLine("Thread End");
            //});

            //th.IsBackground = true;
            //th.Start();
            //Console.WriteLine("After Thread Start");
            //for (int i = 2000; i < 3000; i++)
            //{
            //    Console.WriteLine($"Main num {i}");
            //}

            //th.Join();
            //Console.WriteLine("After Thread Join");
            //for (int i = 3000; i < 4000; i++)
            //{
            //    Console.WriteLine($"Join num {i}");
            //}

            #endregion


            #region Background Thread

            //Console.WriteLine("Main Thread Started");
            //Thread t = new Thread(() =>
            //{
            //    Console.WriteLine("Thread Start");
            //    for (int i = 0; i < 2000; i++)
            //    {
            //        Console.WriteLine($"Thread num {i}");
            //    }
            //    Console.WriteLine("Thread End");
            //});

            //t.Start();
            //t.IsBackground = true;
            //for (int i = 2000; i < 2200; i++)
            //{
            //    Console.WriteLine($"Main num {i}");
            //}
            //Console.WriteLine("Main Thread Ended");

            #endregion

            Console.WriteLine("Main Thread Started");

            ThreadPool.QueueUserWorkItem((arg) =>
            {
                Console.WriteLine("\tThread 1 Start");
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"\tThread 1 num {i}");
                }
                Console.WriteLine("\tThread 1 End");
            });

            ThreadPool.QueueUserWorkItem((arg) =>
            {
                Console.WriteLine("\t\tThread 2 Start");
                for (int i = 100; i < 200; i++)
                {
                    Console.WriteLine($"\t\tThread 2 num {i}");
                }
                Console.WriteLine("\t\tThread 2 End");
            });

            ThreadPool.QueueUserWorkItem((arg) =>
            {
                Console.WriteLine("\t\t\tThread 3 Start");
                for (int i = 200; i < 300; i++)
                {
                    Console.WriteLine($"\t\t\tThread 3 num {i}");
                }
                Console.WriteLine("\t\t\tThread 3 End");
            });

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine($"Main {i}");
            }

            ThreadPool.QueueUserWorkItem((arg) =>
            {
                Console.WriteLine("\t\t\t\tThread 4 Start");
                for (int i = 300; i < 400; i++)
                {
                    Console.WriteLine($"\t\t\t\tThread 4 num {i}");
                }
                Console.WriteLine("\t\t\t\tThread 4 End");
            });

            for (int i = 500; i < 1000; i++)
            {
                Console.WriteLine($"Main {i}");
            }

            Console.WriteLine("Main Thread Ended");

        }
    }
}
