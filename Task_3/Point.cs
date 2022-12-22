using System.Drawing;
using System.Net.NetworkInformation;

namespace Task_3
{
    internal class Point
    {
        public int X;
        public int Y;
        public string Name;
        public void DisplayCoordinates()
        {
           Console.WriteLine(Name + " = (" + X + "," + Y + ")");
        }

        

    }
}
