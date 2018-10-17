using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animal
    {
        public abstract string Habitat { get; set; }
        public abstract string Diet { get; set; }

        /// <summary>
        /// Abstract method that allows Animal to make their unique cry.
        /// </summary>
        /// <returns>Sound of the animal</returns>
        public abstract string MakeSound();

        /// <summary>
        /// Abstract method that has the Animal give birth.
        /// </summary>
        /// <returns>What is birthed from Animal</returns>
        public abstract string GiveBirth();
    }
}
