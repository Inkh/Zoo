using System;
using Xunit;
using Zoo.Classes;

namespace ZooTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Proves inheritance
        /// </summary>
        [Fact]
        public void IsAnimalTest()
        {
            Cat kimchi = new Cat();
            Assert.True(kimchi is Animal);
        }

        /// <summary>
        /// Proves polymorphism
        /// </summary>
        [Fact]
        public void CatPolymorphismTest()
        {
            Cat kimchi = new Cat();
            Assert.True(kimchi.MakeSound() == "MEOW!!");
        }

        /// <summary>
        /// Proves polymorphism
        /// </summary>
        [Fact]
        public void OctopusPolymorphismTest()
        {
            Octopus octo = new Octopus();
            Assert.True(octo.MakeSound() == "Gurgle gurgle");
        }

        /// <summary>
        /// Proves interface implementation
        /// </summary>
        [Fact]
        public void CatInterfaceTest()
        {
            Cat kimchi = new Cat();
            Assert.True(kimchi.SurviveUnderWater == false);
        }

        [Fact]
        public void DolphinInterfaceTest()
        {
            Dolphin dolly = new Dolphin();
            Assert.True(dolly.SurviveUnderWater == true);
        }
    }
}
