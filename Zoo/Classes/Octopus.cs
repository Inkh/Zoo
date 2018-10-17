using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Octopus : Cephalopod
    {
        public override int NumberOfTentacles { get; set; } = 8;
        public override string Habitat { get; set; } = "Pacific Waters";
        public override string Diet { get; set; } = "Small crabs and other octopuses";

        public override string Crawl()
        {
            return "Crawls slowly with its tentacles. It's having a peaceful day";
        }

        public override string GiveBirth()
        {
            return "Wait... Do you see that? That's a bunch of eggs! Thousands of them!";
        }

        public override string MakeSound()
        {
            return "Gurgle gurgle";
        }

        public string Wrap()
        {
            return "The octopus expands its tentacles and wraps on target. The target suffers from speed down!";
        }
    }
}
