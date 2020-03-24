using System;
using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient("Pomme", true,false));
            ingredients.Add(new Ingredient("salade", false,false));
            ingredients.Add(new Ingredient("tomate", false,true));
            ingredients.Add(new Ingredient("poisson", true,true));
            Kebab kebab = new Kebab();
            Console.Out.WriteLine(kebab.IsAllVeggie(ingredients));
            Console.Out.WriteLine(kebab.IsAllPescetarien(ingredients));
        }
    }
}