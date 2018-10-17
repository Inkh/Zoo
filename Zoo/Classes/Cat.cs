using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Cat : TerrestrialMammal, IDoTricks, ISwim
    {
        public override string SizeOfBaby { get; set; } = "18 inches long and 9lbs";
        public override bool BreatheOnLand { get; set; } = true;
        public override string Habitat { get; set; } = "Anywhere and everywhere. Sometimes on your lap.";
        public override string Diet { get; set; } = "Meat";
        public bool UnderstandsCommand { get; set; } = true;
        public bool SurviveUnderWater { get; set; } = false;

        /// <summary>
        /// Cats on average gives birth to a litter of 5
        /// </summary>
        /// <returns></returns>
        public override string GiveBirth()
        {
            return "Look! Five adorable kittens are born!";
        }

        /// <summary>
        /// Meows and purrs
        /// </summary>
        /// <returns></returns>
        public override string MakeSound()
        {
            return "MEOW!!";
        }

        /// <summary>
        /// Describes a common cat behavior.
        /// </summary>
        /// <returns>Post scratch description</returns>
        public string ScratchHuman()
        {
            return "The cat scratches you. You now have bleeding gashes on your forearm.";
        }

        /// <summary>
        /// Overriden Run from parent class TerrestrialMammal.
        /// </summary>
        /// <returns>More descriptions on how Cats move</returns>
        public override string Run()
        {
            return base.Run() + " And it leaps super high too!";
        }

        /// <summary>
        /// Cats don't like tricks
        /// </summary>
        /// <returns></returns>
        public string DoTrick()
        {
            return "What? You want me to do a trick? No!";
        }

        public string Swim()
        {
            return "The cat paddles. It looks at you hatefully. Your friendship is ruined.";
        }
    }
}
