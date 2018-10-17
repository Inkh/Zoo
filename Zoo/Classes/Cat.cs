using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Cat : TerrestrialMammal
    {
        public override string SizeOfBaby { get; set; } = "18 inches long and 9lbs";
        public override bool BreatheOnLand { get; set; } = true;
        public override string Habitat { get; set; } = "Anywhere and everywhere. Sometimes on your lap.";
        public override string Diet { get; set; } = "Meat";

        public override string GiveBirth()
        {
            return "Look! Five adorable kittens are born!";
        }

        public override string MakeSound()
        {
            return "MEOW!!";
        }

        public string ScratchHuman()
        {
            return "The cat scratches you. You now have bleeding gashes on your forearm.";
        }

        public override string Run()
        {
            return base.Run() + " And it leaps super high too!";
        }
    }
}
