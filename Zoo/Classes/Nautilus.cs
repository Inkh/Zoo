using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Nautilus : Cephalopod
    {
        public override int NumberOfTentacles { get; set; } = 90;
        public override string Habitat { get; set; } = "Tropical Indo-Pacific";
        public override string Diet { get; set; } = "Shrimps, crabs, and small fishes";
        public override bool HasShell { get; set; } = true;

        public override string Crawl()
        {
            return "Is it really crawling? Oh yes, it's moving real slow";
        }

        public override string GiveBirth()
        {
            return "How cute, it just laid 10 eggs!";
        }

        public override string MakeSound()
        {
            return "It made a sound, but it's too quiet for you to hear.";
        }

        public string BeAFossil()
        {
            return "It's not moving... Is it..- Oh, it's a fossil now.";
        }
    }
}
