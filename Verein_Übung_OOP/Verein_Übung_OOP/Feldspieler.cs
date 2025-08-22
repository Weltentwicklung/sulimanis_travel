using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Verein_Übung_OOP
{
    internal class Feldspieler
    {
        public string Name { get; set; }

        public Feldspieler(string name) 
        {
            if (name == null)
            {
                Console.WriteLine("Leider wurde der Feldspieler ohne Namen erstellt. Wir nennen ihn \"Willy\".\nDer Name kann jederzeit über die Eigenschaft Feldspieler.Name geändert werden.");
                name = "Willy";
            }

            Name = name;
        }

        public void Graetschen()
        {
            Console.WriteLine($"{Name} holt sich den Ball mit einer sensationellen Grätsche...");
        }

        public void ToreSchiessen()
        {
            Console.WriteLine($"... und und\nTOOOR!\n{Name} schiesst ein Toor, unblaublich!");
        }
    }
}
