using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Cephalopod : Animal, ISwim
    {
        public virtual bool HasShell { get; set; } = false;
        public abstract int NumberOfTentacles { get; set; }
        public bool SurviveUnderWater { get; set; } = true;

        /// <summary>
        /// Outputs Cephalopod crawling
        /// </summary>
        /// <returns>Cephalopod crawl animation</returns>
        public abstract string Crawl();

        /// <summary>
        /// Swim
        /// </summary>
        /// <returns></returns>
        public abstract string Swim();
    }
}
