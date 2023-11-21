namespace esercizio_6_dotnet
{
    internal class Class1Base
    {
        public int publicCall = 1;
        protected int protectedCall = 3;
        internal int internalCall = 4;
        private int privateCall = 2;
        public void intCall()
        {
            Console.WriteLine($"Chiamata interna: {internalCall}");
        }
        public void priCall()
        {
            Console.WriteLine($"Chiamata privata: {privateCall}");

        }
        public void protCall()
        {
            Console.WriteLine($"Chiamata protetta: {protectedCall}");
        }

        public void publcall()
        {
            Console.WriteLine($"Chiamata pubblica: {publicCall}");

        }
    }
}