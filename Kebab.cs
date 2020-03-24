namespace ConsoleApplication1
{
    public class Kebab
    {
        private bool salade;
        private bool tomate;
        private bool oignon;
        private bool viande;

        public Kebab(bool salade, bool tomate, bool oignon, bool viande)
        {
            this.salade = salade;
            this.tomate = tomate;
            this.oignon = oignon;
            this.viande = viande;
        }
        
        public bool IsAllVeggie()
        {
            return salade && tomate && oignon;
        }
    }
}