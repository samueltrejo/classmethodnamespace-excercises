using System;

namespace Lego_Minigifures
{
    class Program
    {
        static void Main(string[] args)
        {
            var halo = new Lego
            {
                Body = "new default",
            };
            Console.WriteLine(halo.Accessories.IsWeapon);
        }
    }
}
