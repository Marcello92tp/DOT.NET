using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_6_dotnet
{
    internal class Class1
    {
        public int publicCall = 1;
        private int privateCall = 2;
        protected int protectedCall = 3;
        internal int internalCall = 4;

        public void publcall()
        {
            Console.WriteLine($"Chiamata pubblica: {publicCall}");                        
        }
        public void priCall()
        {
            Console.WriteLine($"Chiamata privata: {privateCall}");
        }
        public void intCall()
        {
            Console.WriteLine($"Chiamata interna: {internalCall}"); 
        }
        public void protCall()
        {
            Console.WriteLine($"Chiamata protetta: {protectedCall}");
        }

        public Class1(int publicCall, int privateCall, int protectedCall, int internalCall)
        {
            this.publicCall = publicCall;
            this.privateCall = privateCall;
            this.protectedCall = protectedCall;
            this.internalCall = internalCall;
        }

        public Class1()
        {

        }
    }
}
