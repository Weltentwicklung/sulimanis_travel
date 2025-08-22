using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Shapes
    {

        public class MyRectangle
        {
            private double length;
            private double height;
            private string content;
        
            private string rectangleGetContent {  
                get {
                    return "This rectangle contains text";
                } 
            }

            private string rectangleSetContent
            {
                set { content = value; }
            }



            public string HexColor
            {

                get
                {

                    return System.Drawing.ColorTranslator.ToHtml(this.color);

                }

                set
                {

                    System.Drawing.ColorTranslator.FromHtml(value);

                }

            }


            private Color color;

            // ❌ WRONG version: setter never assigns to `this.color`
            public string HexColor
            {
                get
                {
                    return ColorTranslator.ToHtml(this.color);
                }
                set
                {
                    // this makes a Color but throws it away!
                    ColorTranslator.FromHtml(value);
                }
            }

        }


    }
}
