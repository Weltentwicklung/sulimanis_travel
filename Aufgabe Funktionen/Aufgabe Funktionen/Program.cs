namespace Aufgabe_Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Welcome statement and program selection
            Console.WriteLine("Willkommen beim Mathematikprogramm, in welchem wir mit Zahlen Jonglieren");
            Console.WriteLine("Freut mich mit dir ein bischen zu rechnen, wie ist dein Name?");
            string userName = Console.ReadLine()!;
            // Multiple rounds of calculation while true:
            bool anotherCalc = true;

            // Schleife für mehrmalige Berechnungen

            do
            {
                int calcNr = 0;

                // Options and option selection for the different calculations. Output is different on the first round

                if (calcNr == 0)
                {
                    Console.WriteLine("\nWir haben folgende Optionen:");
                }
                else if (calcNr == 1)
                {
                    Console.WriteLine("\nOh, noch eine Runde Mathe ヽ(⌒▽⌒)ﾉ\nNa dann los.\nHiernochmals die Optionen");
                }
                else
                {
                    Console.WriteLine("\nSchon die " + (calcNr + 1) + "te Runde ヽ(⌒▽⌒)ﾉ\nOptionen:");
                }

                Console.WriteLine("1 -> Berechnung des grössten gemeinsamen Teilers aus 2 Zahlen");
                Console.WriteLine("2 -> Berechnung des grössten gemeinsamen Teilers aus 2 Zahlen\n(Ist von der Ausgabe her genau das gleiche wie Option 1)");
                Console.WriteLine("3 -> Berechnung des kleinsten gemeinsamen Vielfachen aus 2 Zahlen");
                Console.WriteLine("4 -> Berechnung des Mittelwerts eines Arrays");
                Console.WriteLine("5 -> Berechnung des tiefsten Wertes eines Arrays");
                Console.WriteLine("6 -> Berechnung des höchsten Wertes eines Arrays");
                Console.WriteLine("\nBitte gebe die gewünschte Option ein:");
                string optionChoosed = Console.ReadLine()!;
                int selectedProgram;
                int wrongSelection = 0;

                // Checks whether the User choosed a valid option.
                // !!!!! If new options are added, the while loop condition must be changed. The last contition needs to be increased by one for each option (selectedProgram > ?)
                // While loop Checks if the user input is valid
                while (!int.TryParse(optionChoosed, out selectedProgram) || selectedProgram < 1 || selectedProgram > 6)
                {
                    if (wrongSelection > 0 && wrongSelection < 9)
                    {
                        Console.WriteLine("(°o°) Uuups, wrong again! Bitte wähle eine gültige Option...");
                    }

                    else if (wrongSelection == 9)
                    {
                        Console.WriteLine("Ok... Schon 9 falsche Eingaben... Noch eine letzte Chance ಠ╭╮ಠ:");
                    }

                    else if (wrongSelection == 10)
                    {
                        Console.WriteLine("I'm OUT (ノಠ益ಠ)ノ彡┻━┻");
                        Environment.Exit(0);
                    }

                    else
                    {
                        Console.WriteLine("... Sir, bitte geben sie eine gültige Zahl aus der Auswahl ein  ¯\\_(ツ)_/¯ :");
                    }
                    optionChoosed = Console.ReadLine()!;
                    wrongSelection += 1;
                }

                //  switch to select the choosen calculation.
                //  Gets the nr from the user with the function "GetNrAandNrB.getNrAandNrB()".
                //  Calculates the Result using "MyMath.X" whereby X is the selected calculation
                switch (selectedProgram)
                {
                    case 1:
                        Console.WriteLine("\nSuper, lass uns den ggT aus zwei Zahlen bestimmen!\n");
                        var (nr1, nr2) = GetUserInput.getNrAandNrB();
                        Console.WriteLine("\nDer ggT aus " + nr1 + " und " + nr2 + " ergibt:");
                        Console.WriteLine("\n" + MyMath.Calc_ggT(nr1, nr2));
                        break;

                    case 2:
                        Console.WriteLine("\n... Wir bestimmen also den ggT \"rekursiv\" (↼_↼)\n");
                        (nr1, nr2) = GetUserInput.getNrAandNrB();
                        Console.WriteLine("\nDer ggT aus " + nr1 + " und " + nr2 + " ergibt:");
                        Console.WriteLine("\n" + MyMath.Calc_ggT_r(nr1, nr2));
                        break;

                    case 3:
                        Console.WriteLine("\nSchön, schön, dann lass und das kgV aus zwei Zahlen bestimmen!\n");
                        (nr1, nr2) = GetUserInput.getNrAandNrB();
                        Console.WriteLine("\nDer kgV aus " + nr1 + " und " + nr2 + " ergibt:");
                        Console.WriteLine("\n" + MyMath.Calc_kgV(nr1, nr2));
                        break;

                    case 4:
                        Console.WriteLine("\nGrandios, wir berechnen den Mittelwert eines Arrays\n");
                        double[] arrAv = GetUserInput.getArray();
                        Console.WriteLine("\nDer Mittelwert aus dem eingegebenen Array ist:");
                        Console.WriteLine("\n" + MyMath.Calc_Arr_Avarage(arrAv));
                        break;

                    case 5:
                        Console.WriteLine("\nGrandios, wir suchen den tiefsten Wert eines Arrays\n");
                        double[] arrSm = GetUserInput.getArray();
                        Console.WriteLine("\nDer tiefste Wert aus dem eingegebenen Array ist:");
                        Console.WriteLine("\n" + MyMath.Calc_Arr_Small(arrSm));
                        break;

                    case 6:
                        Console.WriteLine("\nGrandios, wir suchen den höchsten Wert eines Arrays\n");
                        double[] arrBi = GetUserInput.getArray();
                        Console.WriteLine("\nDer höchste Wert aus dem eingegebenen Array ist:");
                        Console.WriteLine("\n" + MyMath.Calc_Arr_Big(arrBi));
                        break;

                        

                }
                calcNr += 1;

                // Asks if user want do do another calculation
                int wrongUserImput = 0;
                string requestAnotherCalc = "";
                // Checks if Imput is eighter J, j, N or n. Exit's the Programm after 10 wrong inputs
                do
                {
                    if (wrongUserImput == 0)
                    {
                        Console.WriteLine("\nSollen wir noch ne Runde Mathe machen?\n(J oder j -> nächste Rechnung / N oder n -> beenden)");
                    }
                    else if (wrongUserImput >= 1 && wrongUserImput <= 9)
                    {
                        Console.WriteLine("\nNoch eine Runde? Bitte gib nur ein:\nJ oder j für eine weitere Runde\nN oder n zum Beenden");
                    }
                    else if (wrongUserImput == 10)
                    {
                        Console.WriteLine("\nUff, wenn du Mühe mit der Eingabe hast, starte das Programm doch einfach neu... (￢_￢) ");
                        Environment.Exit(0);
                    }
                    requestAnotherCalc = Console.ReadLine()!;
                    wrongUserImput++;
                } while (requestAnotherCalc.ToUpper() != "J" && requestAnotherCalc.ToUpper() != "N");

                if (requestAnotherCalc.ToUpper() == "J")
                {
                    anotherCalc = true;
                }
                else
                {
                    anotherCalc = false;
                }

            } 
            while (anotherCalc == true);

            Console.WriteLine("\nHat mich gefreut mit dir Zahlen zu jonglieren, bis auf ein andermal " + userName);

                /*
            int resultat = MyMath.Calc_ggT(10, 4);
            Console.WriteLine(resultat);

            int resultat2 = MyMath.Calc_kgV(10, 4);
            Console.WriteLine(resultat2);
                */
        }

        // Returns 2 Integers from user input for further calculations
        
    }
}
