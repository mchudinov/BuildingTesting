using System;

namespace BuildTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mc = new MyClass();
            Console.WriteLine(mc.Multiply(2,3));
        }
    }
}
