using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Verein_Übung_OOP
{
    internal class Torwart
    {
        public string Name { get; set; }

        public Torwart(string name)
        {
            if (name == null)
            {
                Console.WriteLine("Leider fehlt der Name des Neuen Torwartes. Wir nennen ihn \"Billy\".\nDer Name kann jederzeit über die Eigenschaft Torwart[Objektname].Name geändert werden.");
                name = "Billy";
            }

            this.Name = name;
        }

        public void BaelleHalten()
        {
            Console.WriteLine($"Unglaublich, {Name} hält den Ball mit einer jahrhundert Parade");
        }
    }
}
