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
            var bandName = FirstCharToUpper(giveName);
            if (giveName[0].Equals(giveName[giveName.Length - 1]))
            {
                for (int i = 1; i < giveName.Length; i++)
                {
                    bandName += giveName[i];
                }
                return bandName;
            }

            return "The " + bandName;
        }

        private static string FirstCharToUpper(string giveName)
        {
            var firstChar = giveName[0].ToString().ToUpper();
            var bandName = firstChar;
            for (int i = 1; i < giveName.Length; i++)
            {
                bandName += giveName[i];
            }

            return bandName;
        }
    }
}