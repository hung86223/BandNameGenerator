using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BandNameGeneratorTest
{
    [TestClass]
    public class BandNameGeneratorTest
    {
        private BandNameGenerator _bandNameGenerator = new BandNameGenerator();

        [TestMethod]
        public void PutTheInFrontWhenGiveNounName()
        {
            var name = "dolphin";

            var bandName = _bandNameGenerator.GenerateBandName(name);

            Assert.AreEqual("The Dolphin", bandName);
        }

        [TestMethod]
        public void DontPutTheFrontWhenGiveSameLetterName()
        {
            var name = "alaska";

            var bandName = _bandNameGenerator.GenerateBandName(name);

            Assert.AreEqual("Alaskalaska", bandName);
        }
    }

    public class BandNameGenerator
    {
        public string GenerateBandName(string giveName)
        {
            string bandName;
            var firstChar = giveName[0].ToString().ToUpper();
            bandName = "The " + firstChar;
            for (int i = 1; i < giveName.Length; i++)
            {
                bandName += giveName[i];
            }

            return bandName;
        }
    }
}