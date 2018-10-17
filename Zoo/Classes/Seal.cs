using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Seal : AquaticMammal, IDoTricks
    {
        public override bool HasGill { get; set; } = false;
        public override string SizeOfBaby { get; set; } = "3 ft long, 25 lb in weight";
        public override bool BreatheOnLand { get; set; } = true;
        public override string Habitat { get; set; } = "Arctic Oceans";
        public override string Diet { get; set; } = "Squid and fish";
        public bool UnderstandsCommand { get; set; } = true;

        public string DoTrick()
        {
            return "The seal plays fetch with you!";
        }

        /// <summary>
        /// Seals typically give birth to only one baby.
        /// </summary>
        /// <returns></returns>
        public override string GiveBirth()
        {
            return "One baby seal is born!";
        }

        /// <summary>
        /// Seals bark, did you know that?
        /// </summary>
        /// <returns></returns>
        public override string MakeSound()
        {
            return "Bark! BARK!!!";
        }

        /// <summary>
        /// Seals love to scratch their bellies
        /// </summary>
        /// <returns></returns>
        public string ScratchBelly()
        {
            return "The seal rolls on its back and scratches its itchy belly";
        }

        public override string Swim()
        {
            return "The Seal glides through the water graciously";
        }
    }
}
