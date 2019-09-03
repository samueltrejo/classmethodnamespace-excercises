using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Favorite_Things.FavoriteThings
{
    class Instrument
    {
        public string TypeOfInstrument { get; set; }
        public bool IsAcoustic { get; set; }
        public string Color { get; set; }

        public Instrument(string typeOfInstrument, bool isAcoustic, string color)
        {
            TypeOfInstrument = typeOfInstrument;
            IsAcoustic = isAcoustic;
            Color = color;
        }

        public void Shred()
        {
            Console.WriteLine($"{TypeOfInstrument}: *Shredding!");
        }

        public void Play()
        {
            Console.WriteLine("Melodic Sounds");
        }
    }
}
