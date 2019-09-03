using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Favorite_Things.FavoriteThings
{
    class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} goes woof!");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} fetched a stick.");
        }


    }
}
