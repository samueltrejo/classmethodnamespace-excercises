using System;
using Your_Favorite_Things.FavoriteThings;

namespace Your_Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamingPC = new Computer("RTX 2080", "M.2", "128GB");
            var lamePC = new Computer("Intel Integrated Graphics", "HDD", "125MB");

            var megamanX = new Videogame("Megaman X", "Retro");
            var rocketLeague = new Videogame("Rocket League", "Sports");

            var guitar = new Instrument("Guitar", true, "flame red");

            var bowser = new Pet("Bowser", "Siberian Husky", 1);


            megamanX.Install();
            rocketLeague.Install();

            gamingPC.PlayGame(megamanX);
            lamePC.PlayGame(rocketLeague);

            guitar.Play();

            bowser.Fetch();
        }
    }
}
