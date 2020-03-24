using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public class Kebab
    {
        

        public bool IsAllVeggie(List<Ingredient> ingredients)
        {
            foreach (var item in ingredients)
            {
                if (!item.isVeggie()) return false;
            }

            return true;
        }
        
        public bool IsAllPescetarien(List<Ingredient> ingredients)
        {
            foreach (var item in ingredients)
            {
                if (!item.isPescetarien()) return false;
            }

            return true;
        }
    }
}