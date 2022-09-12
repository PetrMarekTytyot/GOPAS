using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static async Task Main()
        {
            //for (var i = 0; i < int.MaxValue; i++)
            //{
            //    var t = new Thread(o =>
            //    {
            //        //Console.WriteLine("Test");
            //        //Console.ReadLine();
            //        //Thread.Sleep(-1);
            //    });
            //    t.Start(null);
            //}

            //for (var i = 0; i < 100; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(o =>
            //    {
            //        Thread.Sleep(10000);
            //        Console.WriteLine("Test");
            //    }); 
            //}

            //var t = Task.Run(() =>
            //{
            //    Console.WriteLine("Test");
            //    return 10;
            //});
            //var t2 = Task.Factory.StartNew(() => { }, TaskCreationOptions);
            //var t3 = new Task(() => { });
            //t3.Start();

            //var pole = Enumerable.Range(0, 128).ToArray();
            //var sw = Stopwatch.StartNew();
            ////var tasks = new Task[pole.Length];
            ////using (var cts = new CancellationTokenSource())
            ////{
            ////    cts.CancelAfter(3000);
            ////    for (var i = 0; i < pole.Length; i++)
            ////    {
            ////        var j = i;
            ////        tasks[i] = Task.Run(() =>
            ////        {
            ////            pole[j] = Sum(pole[j], pole[j], cts.Token);
            ////        }, cts.Token);
            ////    }
            ////    Task.WaitAll(tasks);
            ////}
            ////Console.WriteLine(SumArray(pole));
            ////var data = pole.AsParallel()
            ////    .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
            ////    .WithMergeOptions(ParallelMergeOptions.FullyBuffered)
            ////    .Select(x => Sum(x, x));
            ////Console.WriteLine(string.Join(", ", data));
            ////Parallel.For(0, pole.Length, (i, pls) =>
            //////for (var i = 0; i < pole.Length; i++)
            ////{
            ////    pole[i] = Sum(pole[i], pole[i]);
            ////    if (pole[i] > 100)
            ////        pls.Break();
            ////}
            ////);
            ////var sum = 0;
            ////Parallel.For(0, pole.Length, 
            ////    () => 0,
            ////    (i, pls, local) =>
            ////    //for (var i = 0; i < pole.Length; i++)
            ////    {
            ////        //sum = sum + pole[i];
            ////        return Sum(local, pole[i]);
            ////    },
            ////    local => Interlocked.Add(ref sum, local));
            ////Console.WriteLine(sum);
            //Console.WriteLine(sw.Elapsed);

            //Timer? t = default;
            //t = new Timer(o =>
            //{
            //    Console.WriteLine(DateTime.UtcNow);
            //    t.Change(1000, -1);
            //}, null, -1, -1);
            //t.Change(0, -1);


            //for (var i = 0; i < 1_000; i++)
            //{
            //    var request = WebRequest.CreateHttp("https://bing.com");
            //    request.BeginGetResponse(ar =>
            //    {
            //        var response = request.EndGetResponse(ar);
            //        var responseStream = response.GetResponseStream();
            //        var ms = new MemoryStream();
            //        ReadStream(responseStream, ms, () =>
            //        {
            //            ms.Dispose();
            //            responseStream.Dispose();
            //            response.Dispose();
            //            Console.WriteLine("Done");
            //        },
            //        ex =>
            //        {
            //            ms.Dispose();
            //            responseStream.Dispose();
            //            response.Dispose();
            //            Console.WriteLine($"ERROR {ex}");
            //        });
            //    }, null);
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Done");

            //_ = Test();

            //D.ebug();
            //await WaitForEnd();
            //Volatile.Read(ref x);
            //Volatile.Write(ref x, 10);
            //Interlocked.CompareExchange(ref x, 10, 0);

            //using (var mre = new ManualResetEvent(false))
            //{
            //    mre.Set();
            //    mre.WaitOne();
            //    mre.Reset();
            //}
            //using (var are = new AutoResetEvent(false))
            //{
            //    are.Set();
            //    are.WaitOne();
            //    are.Reset();
            //}
            //using (var sem = new Semaphore(20, 20))
            //{
            //    sem.WaitOne();
            //    sem.Release();
            //}
            //using (var m = new Mutex(true, @"Global\Test"))
            //{
            //    Console.ReadLine();
            //    //m.WaitOne();
            //    //m.ReleaseMutex();
            //}

            //var JeToNaZamykani = new object();
            //var counter = 0;
            //try
            //{
            //    lock (JeToNaZamykani)
            //    {
            //        counter = 0;
            //        Test().Wait();
            //        counter = 1;
            //    }
            //}
            //catch (WebException ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //var rwl = new ReaderWriterLockSlim();

            //Lazy<int> l = new Lazy<int>(() => 10, LazyThreadSafetyMode.PublicationOnly);
            //l.IsValueCreated

            //ConcurrentBag
            var bc = new BlockingCollection<int>(10);
            bc.Add(1);
            bc.Add(3);
            bc.Add(5);
            ThreadPool.QueueUserWorkItem(o =>
            {
                foreach (var item in bc.GetConsumingEnumerable())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Hotovo");
            });
            Thread.Sleep(10000);
            bc.Add(45);
            bc.CompleteAdding();

            Console.ReadLine();
            Console.WriteLine("Konec");
        }

        class MyList<T> : IList<T>
        {
            List<T> _inner;
            int _count;

            public MyList()
            {
                _inner = new List<T>();
            }

            public int Count
            {
                get
                {
                    return Volatile.Read(ref _count);
                }
            }
            public void Add(T item)
            {
                lock (_inner)
                {
                    _inner.Add(item);
                    _count++;
                }
            }

            public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool IsReadOnly => throw new NotImplementedException();

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(T item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public int IndexOf(T item)
            {
                throw new NotImplementedException();
            }

            public void Insert(int index, T item)
            {
                throw new NotImplementedException();
            }

            public bool Remove(T item)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        /*volatile*/
        static int x;

        class F : IDisposable
        {
            ManualResetEvent _event;
            int _count;

            public F(int count)
            {
                _event = new ManualResetEvent(false);
                _count = count;
            }

            public void Dispose()
            {
                _event.Dispose();
            }

            public void Signal()
            {
                if (Interlocked.Decrement(ref _count) == 0)
                    _event.Set();
            }

            public void WaitOne()
            {
                _event.WaitOne();
            }
        }

        static class SimpleLock
        {
            static int _lockTaken = 0;

            public static void Enter()
            {
                while (Interlocked.Exchange(ref _lockTaken, 1) == 1)
                {
                    Thread.SpinWait(4000);
                }
            }

            public static void Exit()
            {
                Volatile.Write(ref _lockTaken, 0);
            }
        }

        static Task WaitForEnd()
        {
            var tcs = new TaskCompletionSource();
            Console.CancelKeyPress += (object? sender, ConsoleCancelEventArgs e) =>
            {
                tcs.SetResult();
            };
            return tcs.Task;
        }

        static async Task Test()
        {
            var tasks = new Task[1000];
            for (var i = 0; i < 1000; i++)
            {
                tasks[i] = Do(i);
            }
            await Task.WhenAll(tasks);

            static async Task Do(int i)
            {
                var request = WebRequest.CreateHttp("https://bing.com");
                using (var response = await request.GetResponseAsync())
                {
                    using (var source = response.GetResponseStream())
                    using (var destination = new MemoryStream())
                    {
                        var buffer = new byte[32 * 1024];
                        while (true)
                        {
                            try
                            {
                                var read = await source.ReadAsync(buffer, 0, buffer.Length);
                                if (read == 0)
                                    break;
                                await destination.WriteAsync(buffer, 0, read);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"ERROR: {ex}");
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Done: {i}");
                }
            }
        }

        static void ReadStream(Stream source, Stream destination, Action onDone, Action<Exception> onError)
        {
            var buffer = new byte[32 * 1024];
            source.BeginRead(buffer, 0, buffer.Length, ar =>
            {
                int read;
                try
                {
                    read = source.EndRead(ar);
                }
                catch (Exception ex)
                {
                    onError(ex);
                    return;
                }
                if (read == 0)
                {
                    onDone();
                    return;
                }
                destination.BeginWrite(buffer, 0, read, ar2 =>
                {
                    try
                    {
                        destination.EndWrite(ar2);
                    }
                    catch (Exception ex)
                    {
                        onError(ex);
                        return;
                    }
                    ReadStream(source, destination, onDone, onError);
                }, null);
            }, null);
        }

        static object[] PFuncs(params Func<object>[] funcs)
        {
            var tasks = new Task<object>[funcs.Length];
            for (var i = 0; i < funcs.Length; i++)
            {
                tasks[i] = Task.Run(funcs[i]);
            }
            Task.WaitAll(tasks);
            return tasks.Select(x => x.Result).ToArray();
        }
        static object[] PFuncs2(params Func<object>[] funcs)
        {
            return funcs.Select(x => Task.Run(x)).Select(x => x.Result).ToArray();
        }
        static object[] PFuncs3(params Func<object>[] funcs)
        {
            var results = new object[funcs.Length];
            Parallel.Invoke(funcs.Select<Func<object>, Action>((e, i) => () => { results[i] = e(); }).ToArray());
            return results;
        }

        static int SumArray(int[] arr)
        {
            switch (arr.Length)
            {
                case 0:
                    return 0;
                case 1:
                    return arr[0];
                case 2:
                    return Sum(arr[0], arr[1]);
                default:
                    var left = arr.Take(arr.Length / 2).ToArray();
                    var right = arr.Skip(arr.Length / 2).ToArray();
                    var leftTask = Task.Run(() => SumArray(left));
                    var rightTask = Task.Run(() => SumArray(right));
                    return Sum(leftTask.Result, rightTask.Result);
            }
        }

        static int Sum(int a, int b, CancellationToken cancellationToken = default)
        {
            for (var i = 0; i < 3; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                Thread.SpinWait(999999);
            }
            return a + b;
        }
    }
}