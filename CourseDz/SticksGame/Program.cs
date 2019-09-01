using System;

namespace SticksGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var g = new UI(10, Player.Human);
            g.Start();
        }
    }
}
