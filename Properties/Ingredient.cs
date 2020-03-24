namespace ConsoleApplication1.Properties
{
    public class Ingredient
    {
        private string name;
        private bool vegetarien;
        private bool pescetarien;

        public Ingredient(string name,bool vegetarien, bool pescetarien)
        {
            this.name = name;
            this.vegetarien = vegetarien;
            this.pescetarien = pescetarien;
        }

        public bool isVeggie()
        {
            return this.vegetarien;
        }
        
        public bool isPescetarien()
        {
            return this.pescetarien;
        }
    }
}