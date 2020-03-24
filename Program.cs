using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kebab kebab = new Kebab(true, true, false, true);
            Console.Out.WriteLine(kebab.IsAllVeggie());
        }
    }
}