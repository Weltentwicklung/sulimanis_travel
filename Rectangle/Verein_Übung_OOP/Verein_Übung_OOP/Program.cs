using System.Reflection.Metadata.Ecma335;

namespace Verein_Übung_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Verein fcSg = new Verein("Fc St. Gallen", "Dr. Haba Kuck");
           
            List<string> spieler = new List<string>() { "Phillip", "Lukas", "Marie", "Curry", "George", "Franzel", "Babette", "Hans Ueli", "Fritz", "Juli" };
            List<string> torwart = new List<string>() { "Alex" };


            Mannschaft mannschaft1 = new Mannschaft("Wir Gewinnen!", spieler, torwart);
            fcSg.AddMannschaft(mannschaft1);
            fcSg.Spiele();
        
        }



    }
}
