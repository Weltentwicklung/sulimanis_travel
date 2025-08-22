using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Funktionen
{
    internal class GetUserInput
    {
        public static (int, int) getNrAandNrB()
        {
            // Create output variables
            int nr1, nr2;

            // Tells the User to give 2 Numbers for the Calc execution a and b
            Console.WriteLine("Zuerst brauchen wir also die beiden Zahlen\n");
            Console.WriteLine("Bitte beachte, dass es natürliche (ganze) Zahlen sein müssen, welche grösser als 0 sind (wir vereinfachen hier und lassen die 0 weg)\n");
            
            // Request for nr1
            Console.WriteLine("\nBitte geben die erste Zahl ein:");
            string userInputA = Console.ReadLine()!;
            int countWrongNrIn = 0;

            // Checkes if its a valid nr was given for a and gives answers based on the nr. of wrong inputs. If countWrongNrIn aborts the Program.
            while (!int.TryParse(userInputA, out nr1) || nr1 < 1)
            {

                switch (countWrongNrIn)
                {
                    case 0:
                        Console.WriteLine("Uuups, da wurde wohl keine gültige Zahl eingegeben. Es soll eine Zahl sein und grösser als 0\n(눈_눈)\nAber im Leben sollten wir mehrere Chancen erhalten, also nochmals (*≧▽≦): \n");
                        break;

                    case 1:
                        Console.WriteLine("Oh, noch eine falsche Zahl. Ich hoff ich hab dies nicht unklar ausgedrückt ( @ . @ ):\n");
                        break;

                    case 2:
                        Console.WriteLine("Hmm, also hier zur Klärung, eine natürliche, ganzzahlige Zahl, die grösser als Null ist:\n");
                        break;

                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        Console.WriteLine("... Schon der " + (countWrongNrIn + 1) + "te Versuch...\nAber das Glück gehört den Tüchtigen, nicht? (¬.¬):\n");
                        break;

                    case 8:
                        Console.WriteLine("... wohl eher nicht (ಠ_ಠ).\nVersuchen wir es nochmals: \n");
                        break;

                    case 9:
                        Console.WriteLine("...\n");
                        break;

                    case 10:
                        Console.WriteLine("Ok mir reichts, mach dein Sch... doch selber\n(╯°□°）╯︵ Goodbye!!!\n");
                        Environment.Exit(0);
                        break;
                }

                userInputA = Console.ReadLine()!;
                countWrongNrIn += 1;
            }

            // Request for nr2
            Console.WriteLine("\nSuper, dann erbitte ich um die zweite Zahl:\n");
            string userInputB = Console.ReadLine()!;

            // Checkes if its a valid nr2 was given. Gives answers based on the nr. of wrong inputs. countWrongNrIn will be stored between the nr1 and nr2 requests. Aborts if countWrongNrIn == 10
            while (!int.TryParse(userInputB, out nr2) || nr2 < 1)
            {

                switch (countWrongNrIn)
                {

                    case 0:
                        Console.WriteLine("Uuups, da wurde wohl keine gültige Zahl eingegeben. Es soll eine Zahl sein und grösser als 0\n(눈_눈)\nAber im Leben sollten wir mehrere Chancen erhalten, also nochmals (◠‿◠):\n");
                        break;

                    case 1:
                        Console.WriteLine("Oh, noch eine falsche Zahl. Ich hoff ich hab dies nicht unklar ausgedrückt ( @ ,. @ ):\n");
                        break;

                    case 2:
                        Console.WriteLine("Hmm, also hier zur Klärung, eine natürliche, ganzzahlige Zahl, die grösser als Null ist:\n");
                        break;

                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        Console.WriteLine("... Schon der " + (countWrongNrIn + 1) + "te Versuch...\nAber das Glück gehört den Tüchtigen, nicht? (¬‿¬):\n");
                        break;

                    case 8:
                        Console.WriteLine("... wohl eher nicht (ಠ_ಠ).\nVersuchen wir es nochmals:\n");
                        break;

                    case 9:
                        Console.WriteLine("...\n");
                        break;

                    case 10:
                        Console.WriteLine("Ok mir reichts, mach dein Sch... doch selber\n(╯°□°）╯︵ Goodbye!!!\n");
                        Environment.Exit(0);
                        break;
                }

                userInputB = Console.ReadLine()!;
                countWrongNrIn += 1;
            }

            return (nr1, nr2);


        }

        public static double[] getArray()
        {
            double userInputArr = Console.ReadLine();
            double.TryParse(userInputArr, out userInputArr);

            double[] userArray = 
            return userArray[];*/

            double[] userArray = { 1, 2, 3, 4, 5, 6 };

            return userArray;
        }
    }
}
