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

        /// <summary>
        /// Octopus crawls slowly
        /// </summary>
        /// <returns></returns>
        public override string Crawl()
        {
            return "Crawls slowly with its tentacles. It's having a peaceful day";
        }

        /// <summary>
        /// Though Octopus' lay thousands of eggs, they only choose a select few.
        /// They nurture the eggs till they hatch, then the parent dies from starvation and exhaustion.
        /// It's kind of sad to be honest.
        /// </summary>
        /// <returns></returns>
        public override string GiveBirth()
        {
            return "Wait... Do you see that? That's a bunch of eggs! Thousands of them!";
        }

        /// <summary>
        /// Octopus gurgles!
        /// </summary>
        /// <returns></returns>
        public override string MakeSound()
        {
            return "Gurgle gurgle";
        }

        /// <summary>
        /// The octopus' signature move
        /// </summary>
        /// <returns>How it wraps and consequence</returns>
        public string Wrap()
        {
            return "The octopus expands its tentacles and wraps on target. The target suffers from speed down!";
        }

        public override string Swim()
        {
            return "The Octopus swims by propelling itself through the currents";
        }
    }
}
