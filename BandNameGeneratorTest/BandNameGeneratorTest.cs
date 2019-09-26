using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BandNameGeneratorTest
{
    [TestClass]
    public class BandNameGeneratorTest
    {
        [TestMethod]
        public void GiveNounNamePutTheInFront()
        {
            var bandNameGenerator = new BandNameGenerator();
            var name = "Dolphin";

            var bandName = bandNameGenerator.GenerateBandName(name);

            Assert.AreEqual("The " + name, bandName);
        }
    }

    public class BandNameGenerator
    {
        public string GenerateBandName(string giveName)
        {
            return "The " + giveName;
        }
    }
}