using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Seal : AquaticMammal
    {
        public override bool HasGill { get; set; } = false;
        public override string SizeOfBaby { get; set; } = "3 ft long, 25 lb in weight";
        public override bool BreatheOnLand { get; set; } = true;
        public override string Habitat { get; set; } = "Arctic Oceans";
        public override string Diet { get; set; } = "Squid and fish";

        public override string GiveBirth()
        {
            return "One baby seal is born!";
        }

        public override string MakeSound()
        {
            return "Bark! BARK!!!";
        }

        public string ScratchBelly()
        {
            return "The seal rolls on its back and scratches its itchy belly";
        }
    }
}
