using System;
using System.Collections.Generic;
using System.Text;

namespace Lego_Minigifures
{
    class Lego
    {
        public string HairHelmet { get; set; } = "Default";
        public string Head { get; set; } = "Default";
        public string Body { get; set; } = "Default";
        public string Legs { get; set; } = "Default";
        public Accessories Accessories { get; set; } = new Accessories();

        public Lego()
        {

        }
    }
}
