using System;

namespace DelegateApp
{
    public delegate string HelperDel(string str);

    class Program
    {
        static void Main(string[] args)
        {
            var testDel = new TestDelegate();
            HelperDel spaceDel = testDel.Space;
            HelperDel reverseDel = testDel.Reverse;
            Console.WriteLine(spaceDel("Pamela"));
            Console.WriteLine(reverseDel("Samuel"));
        }
    }
}
