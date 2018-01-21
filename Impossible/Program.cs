using System;

namespace Impossible
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            Console.WriteLine(a == 1 && a== 2 && a==3);
            Console.ReadKey();
        }
    }
}
