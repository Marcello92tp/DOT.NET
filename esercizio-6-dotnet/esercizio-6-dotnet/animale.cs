using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_6_dotnet
{
    internal class Animale
    {
        public string Nome { get; protected set; }
        public int Età { get; protected set; }

        public Animale(String Nome, int Età)
        {
            this.Nome = Nome;
            this.Età = Età;
        }

        public virtual void Speak()
        {
            Console.WriteLine($"Verso del {Nome}");
        }

    }
}
