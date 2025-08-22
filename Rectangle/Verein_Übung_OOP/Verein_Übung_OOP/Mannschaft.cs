using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein_Übung_OOP
{
    internal class Mannschaft
    {

        private List<Feldspieler> feldspielerListe = new List<Feldspieler>();
        private List<Torwart> torwartListe = new List<Torwart>();

        public string Motto { get; set; }

        public Mannschaft(string motto, List<string> namenFeldspieler, List<string> namenTorwart)
        {
            Motto = motto;

            if (namenFeldspieler.Count < 10)
            {
                Console.WriteLine("Exeption: Die Mindestanzahl Feldspieler für eine Mannschaft beträgt 10!!!");
            }

            if (namenTorwart.Count < 1)
            {
                Console.WriteLine("Exeption: Eine Mannschaft muss mindestens einen Torwart haben...");
            }

            foreach (string name in namenFeldspieler)
            {
                AddFeldspieler(name);
            }

            foreach (string name in namenTorwart)
            {
                AddTorwart(name);
            }

        }

        public void AddTorwart(string name)
        {
            torwartListe.Add(new Torwart(name));
        }

        public void AddFeldspieler(string name)
        {
            feldspielerListe.Add(new Feldspieler(name));
        }

        public void Spiele()
        {
            foreach (Torwart torwart in torwartListe)
            {
                torwart.BaelleHalten();
            }
            foreach (Feldspieler feldspieler in feldspielerListe)
            {
                feldspieler.ToreSchiessen();
                feldspieler.Graetschen();
            }
        }
    }
}
