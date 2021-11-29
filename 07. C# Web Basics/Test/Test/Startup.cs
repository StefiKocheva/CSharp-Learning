using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    public static class Startup
    {
        public static void Main()
        {//vunshen resurs da swurshi nqkwa abota async methodi
            // po malki podzadachi koito she izpuln task skejulura
            var sw = Stopwatch.StartNew();
            var count = 0;
            var lockObg = new Object();
            //for (int i = 1; i < 100000; i++) { 
                Parallel.For(1, 1000001, (i)=> // same princip po malko vreme / tredove 
                {
                    bool isPrime = true;

                    for (int div = 2; div <= Math.Sqrt(i); div++)
                    {
                        if (i % div == 0)
                        {
                            isPrime = false;
                        }
                    }

                    if (isPrime)
                    {
                        lock (lockObg)
                        {
                            count++;
                        }
                    }
                });
            //{
                
            Console.WriteLine(count);
            Console.WriteLine(sw.Elapsed);
                // ctrl +k +c - comentar 
                // async / await
                //Task Paralel Library (TRL)
                //Task.Run(() =>
                //{
                //    for (int i = 0; i < 1000; i++)
                //    {
                //        Console.WriteLine(i);
                //    }
                //}).ContinueWith((previousTask) =>//kpgato e gotowo izpulni// kude swurshva ednata pod zadachata i pochva drugata
                //{
                //    for (int i = 0; i < 1000; i++)
                //    {
                //        Console.WriteLine(i);
                //    }
                //});

                //    Task.Run(() =>
                //{
                //    for (int i = 1000; i < 2000; i++)
                //    {
                //        Console.WriteLine(1);
                //    }
                //});

                //while (true)
                //{
                //    var line = Console.ReadLine();
                //    Console.WriteLine(line.ToLower());
                //}
                //cant catch thread with tru catch
                ////dead lock
                //var lockObj1 = new object();
                //var lockObj2 = new object();
                //
                //var thread1 = new Thread(() =>
                //{
                //    Monitor.Enter(lockObj1);
                //    //lock (lockObj1)
                //    {
                //        Thread.Sleep(1000);
                //        lock (lockObj2)
                //        {
                //        }
                //    }
                //    Monitor.Exit(lockObj1);
                //});
                //var thread2 = new Thread(() =>
                //{
                //    lock (lockObj2)
                //    {
                //        Thread.Sleep(1000);
                //        lock (lockObj1)
                //        {
                //        }
                //    }
                //});
                //
                //thread1.Start();
                //
                //thread2.Start();
                //thread1.Join();
                //thread2.Join();
                //

                //var numbers = new ConcurrentQueue<int>(Enumerable.Range(0, 10000).ToList());
                //
                //for (int i = 0; i < 4; i++) //problmes on level lists
                //{
                //    new Thread(() =>
                //    {
                //        while (numbers.Count > 0)
                //        {
                //            numbers.TryDequeue(out _);
                //        }
                //    }).Start();
                //}
                //
                //return;
                //
                //object lockObject = new object();
                //decimal count = 0;

                //var threadOne = () => {            
                //for (int i = 0; i < 100000; i++)
                //{
                //    for (int i = from; i <= to; i++)
                //    {
                //        bool isPrime = true;
                //
                //        for (int div = 2; div <= Math.Sqrt(i); div++)
                //        {
                //            if (i % div == 0)
                //            {
                //                isPrime = false;
                //            }
                //        }
                //
                //        if (isPrime)
                //        {
                //            count++;
                //        }
                //    }
                ////money++; - problem with shared resource
                //// solve for the problem
                //// money++; // 3 instruction - r1 - money, r1 = r1 + 1, money = r1
                ////});
            }   //
            //
            //threadOne.Start();
            //
            //var threadTwo = () =>
            //{
            //    for (int i = 5000001; i < 100000; i++)
            //    {
            //        for (int i = from; i <= to; i++)
            //        {
            //            bool isPrime = true;
            //
            //            for (int div = 2; div <= Math.Sqrt(i); div++)
            //            {
            //                if (i % div == 0)
            //                {
            //                    isPrime = false;
            //                }
            //            }
            //
            //            if (isPrime)
            //            {
            //                count++;
            //            }
            //        }
            //        //money++; - problem with shared resource
            //        // solve for the problem
            //        // money++; // 3 instruction - r1 - money, r1 = r1 + 1, money = r1
            //    }
            //};
            //
            //threadTwo.Start();
            //
            //Thread thread = new Thread(MyThreadMainMethod);
            //thread.Start();
            //
            //threadOne.Join();//thread has own stack race condition two threads da se borqt za obshta pamet and then greshni danni
            //threadTwo.Join();
            //
            ////Console.WriteLine(money);
        }   //
            //
        //private static void MyThreadMainMethod()
        //{
        //    var sw = Stopwatch.StartNew();
        //    Console.WriteLine(CountPrimeNumbers(1, 10000000));
        //    Console.WriteLine(sw.Elapsed);
        //}

    //}
}
