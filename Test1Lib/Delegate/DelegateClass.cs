using System;

namespace Delegate
{
    public class DelegateClass
    {
        public delegate void Opgave1();

        public delegate float Opgave2();

        public delegate void Opgave3(string a, string b, string c);

        public static Opgave1 opgave1 = () => Console.WriteLine("Hello");
        public static Opgave2 opgave2 = () => 0.17f;

        public static Opgave3 opgave3 = (a, b, c) =>
            Console.WriteLine($"Parameter 1: {a} & Parameter 2: {b} & Parameter 3: {c}");
    }
}