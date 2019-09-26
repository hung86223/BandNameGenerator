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
            if (IsFirstCharEqualsTheLastChar(giveName))
            {
                return bandName.CopyName(giveName);
            }

            return "The " + bandName;
        }

        private static bool IsFirstCharEqualsTheLastChar(string giveName)
        {
            return giveName[0].Equals(giveName[giveName.Length - 1]);
        }

        private static string FirstCharToUpper(string giveName)
        {
            var bandName = giveName[0].ToString().ToUpper();

            return bandName.CopyName(giveName);
        }
    }
}