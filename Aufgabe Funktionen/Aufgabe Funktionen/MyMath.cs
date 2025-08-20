using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Funktionen
{
    // Mathematic formulas for our math-playground
    internal class MyMath
    {
        // for Calculating the ggT
        public static int Calc_ggT(int a, int b) {
            int z = 0;
            do
            {
                z = a % b;
                a = b;
                b = z;
            }
            while (b != 0);
            return a;
        }

        // Calculating the ggT recursive
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
             
            return Calc_ggT_r(b, a % b);
            
        }

        // Calculating the kgV from the ggT
        public static int Calc_kgV(int a, int b)
        {
            return a * b / Calc_ggT(a, b);

        }

        // Calculates the average of an array
        public static double Calc_Avarage(double[] arrayAverage)
        {
            double sumAverage = 0;
            for (int i = 0; i < arrayAverage.Length; i++)
            {
                sumAverage += arrayAverage[i];
            }
                    
            double resultAverage = sumAverage / arrayAverage.Length;
            return resultAverage;
        }

        



    }
}
