using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Favorite_Things.FavoriteThings
{
    class Videogame
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public Videogame(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public void Install()
        {
            Console.WriteLine($"{Name} has been installed");
        }

        public void Uninstall()
        {
            Console.WriteLine($"{Name} has been uninstalled");
        }
    }
}
