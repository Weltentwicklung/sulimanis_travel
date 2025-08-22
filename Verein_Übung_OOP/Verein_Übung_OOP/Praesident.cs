using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein_Übung_OOP
{
    internal class Praesident
    {
        public string Name { get; set; }

        public void VertraegeUnterzeichnen() {
            Console.WriteLine($"Ich {Name} unterzeichne hiermit einen neuen Vertrag!!");
        }
    }
}
