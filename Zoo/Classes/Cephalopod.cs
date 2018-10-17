using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Cephalopod : Animal
    {
        public virtual bool HasShell { get; set; } = false;
        public abstract int NumberOfTentacles { get; set; }

        /// <summary>
        /// Outputs Cephalopod crawling
        /// </summary>
        /// <returns>Cephalopod crawl animation</returns>
        public abstract string Crawl();
    }
}
