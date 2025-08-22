namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle();

            Console.WriteLine("Initial HexColor: " + rect.HexColor);

            rect.HexColor = "#FF0000"; // trying to set to red

            Console.WriteLine("After setting to red, HexColor: " + rect.HexColor);

            rect.HexColor = "#00FF00"; // trying to set to green

            Console.WriteLine("After setting to green, HexColor: " + rect.HexColor);

            Console.ReadLine();
        }
    }
}
