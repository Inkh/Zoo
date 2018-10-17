using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Dolphin : AquaticMammal, IDoTricks
    {
        public override bool HasGill { get; set; } = false;
        public override string SizeOfBaby { get; set; } = "4 ft and 35 lbs";
        public override bool BreatheOnLand { get; set; } = true;
        public override string Habitat { get; set; } = "Tropical Waters";
        public override string Diet { get; set; } = "Fish";
        public bool UnderstandsCommand { get; set; } = true;

        /// <summary>
        /// Dolphins can sometimes give birth to twins.
        /// </summary>
        /// <returns></returns>
        public override string GiveBirth()
        {
            return "Oh look!! Two twin baby dolphins are born!!";
        }

        /// <summary>
        /// Dolphins make clicking sounds.
        /// </summary>
        /// <returns></returns>
        public override string MakeSound()
        {
            return "Click, click. It's trying to talk to you! Too bad you can't understand..";
        }

        /// <summary>
        /// Dolphins' signature move
        /// </summary>
        /// <returns></returns>
        public string JumpAndFlip()
        {
            return "The dolphin jumps out of the water and does a majestic flip.";
        }

        public string DoTrick()
        {
            return "The dolphin balances a beach ball";
        }
    }
}
