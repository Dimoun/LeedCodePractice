using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Test
    {
        //static void Main(string[] args)
        //{
        //    //string s1 = "Hello";
        //    //string s2 = string.Copy(s1);
        //    //string s3 = s1;

        //    //Console.WriteLine(s1.Equals(s2)); // 输出：false
        //    //Console.WriteLine(s1 == s2);      // 输出：false

        //    //Console.WriteLine(s1.Equals(s3)); // 输出：true
        //    //Console.WriteLine(s1 == s3);      // 输出：true

        //    //MyBaseClass baseObj = new MyBaseClass();
        //    //baseObj.MyMethod(); // 输出 "Base implementation"

        //    //MyDerivedClass derivedObj = new MyDerivedClass();
        //    //derivedObj.MyMethod(); // 输出 "Derived implementation"

        //    //MyBaseClass derivedAsBase = new MyDerivedClass();
        //    //derivedAsBase.MyMethod(); // 也输出 "Derived implementation"
        //    //int a = 1;
        //    //int b = 1;
        //    //Console.WriteLine(a++);
        //    //Console.WriteLine(++b);

        //    //const int c = 1;
        //    //c = 2;
        //    //Console.WriteLine(c);

        //    //int minWorkerThreads, minCompletionPortThreads;
        //    //int maxWorkerThreads, maxCompletionPortThreads;
        //    //int work, com;
        //    //ThreadPool.GetMinThreads(out minWorkerThreads, out minCompletionPortThreads);
        //    //ThreadPool.GetMaxThreads(out maxWorkerThreads, out maxCompletionPortThreads); 
        //    //ThreadPool.GetAvailableThreads(out work, out com);
        //    //Console.WriteLine("线程池的最小工作线程数: " + minWorkerThreads);
        //    //Console.WriteLine("线程池的最小完成端口线程数: " + minCompletionPortThreads);
        //    //Console.WriteLine("线程池的最大工作线程数: " + maxWorkerThreads);
        //    //Console.WriteLine("线程池的最大完成端口线程数: " + maxCompletionPortThreads);
        //    //Thread thread = new Thread(obj=> { Thread.Sleep(3000); });
        //    //thread.Start();
        //    //Task task = new Task();
        //    //task.Result;
        //    MyClass obj1 = new MyClass();
        //    MyClass obj2 = new MyClass();
        //}
        class MyClass
        {
            static int staticField = InitializeStaticField();
            int instanceField;

            static MyClass()
            {
                Console.WriteLine("Static constructor");
            }

            public MyClass()
            {
                Console.WriteLine("Instance constructor");
            }

            static int InitializeStaticField()
            {
                Console.WriteLine("Initialize static field");
                return 0;
            }

            int InitializeInstanceField()
            {
                Console.WriteLine("Initialize instance field");
                return 0;
            }
        }

    }
    public class MyBaseClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Base implementation");
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public override void MyMethod() // 使用 final 修饰符
        {
            base.MyMethod();
            Console.WriteLine("Derived implementation");
        }
    }
}
