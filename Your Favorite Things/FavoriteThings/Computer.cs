using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Favorite_Things.FavoriteThings
{
    class Computer
    {
        public string GPU { get; set; }
        public string TypeOfStorage { get; set; }
        public string AmountOfMemory { get; set; }

        public Computer(string gpu, string typeOfStorage, string amountOfMemory)
        {
            GPU = gpu;
            TypeOfStorage = typeOfStorage;
            AmountOfMemory = amountOfMemory;
        }

        public void Browse(string website)
        {
            Console.WriteLine($"You navigated to {website}");
        }

        public void PlayGame(Videogame videogame)
        {
            Console.WriteLine($"You are playing {videogame.Name}");
        }
    }
}
