using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein_Übung_OOP
{
    internal class Verein
    {
        private List<Mannschaft> mannschaftsListe = new List<Mannschaft>();
        private Physiotheraputin physiotheraputin;
        public Praesident praesident { get; private set; }
        public string Name { get; set; }

        public Verein(string nameVerein, string namePraesident) { 
            Name = nameVerein;
            praesident = new Praesident();
            praesident.Name = namePraesident;     

        }

        public void AddMannschaft(Mannschaft mannschaft)
        {
            if (mannschaftsListe.Count < 10)
            {
                mannschaftsListe.Add(mannschaft);
            }

        }

        public void SetPhysiotherapeutin(Physiotheraputin therapeutin)
        {
            physiotheraputin = therapeutin;
        }

        public void Spiele()
        {
            foreach (Mannschaft mannschaft in mannschaftsListe)
            {
                mannschaft.Spiele();
            }
        }

    }
}
