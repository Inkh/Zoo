using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface ISwim
    {
        bool SurviveUnderWater { get; set; }

        string Swim();
    }
}
