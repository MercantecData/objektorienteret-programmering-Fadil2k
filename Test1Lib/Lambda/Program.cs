using System;

namespace Lambda
{
    public delegate int Add(int a);

    public delegate float FloatSum(float a, float b, float c);

    public delegate string Hello();

    internal class Program
    {
        private static void Main(string[] args)
        {
            Add add = a => a * 2;
            Console.WriteLine(add(10));

            FloatSum floatSum = (a, b, c) => a + b + c;
            Console.WriteLine(floatSum(7.1f, 0.7f, 2.5f));

            Hello hello = () => "Hello world!";
            Console.WriteLine(hello());
        }
    }
}