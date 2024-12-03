using System.Net.Sockets;

namespace XayDungfan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fan fan1 = new fan(fan.MEDIUM, true, 5, "Blue" );
            fan fan2 = new fan(fan.HIGH, false, 10, "White");
            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
        }
    }
}
