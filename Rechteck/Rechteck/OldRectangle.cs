using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class OldRectangle
    {
        /*
        public string standartwert = "Antwort auf Alles, das Universum und überhaupt";
        public string accessFieldPublic = "null";
        public readonly string readOnlyField = "nothing";

        public string GetterSetter(string a)
        {
            string intA = a;

            return intA;
        }*/

        /*
        private int width;
        private int height;

        public int Width()
        {
            return width;
        }
        public void SetWidth(int width)
        {
            this.width = width;

        }*/

        //C#spezifisch
        /*
        public int Width { get; set; }
        public int Height { get; set; } 

        public int Area
        {
            get
            {
                return Width * Height;
            }
        }*/
        //das selbe wie (expression-bodied....)
        /*
        public int Area => Width * Height;
        */
    }
}
