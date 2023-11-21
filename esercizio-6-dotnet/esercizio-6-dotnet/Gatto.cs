using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_6_dotnet
{
    internal class Gatto : Animale
    {
        public Gatto(String Name, int Age) : base(Name, Age) 
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Nome} di {Età} Anni fa bau bau");
        }
    }
}
