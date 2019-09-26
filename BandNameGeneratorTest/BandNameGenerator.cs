namespace BandNameGeneratorTest
{
    public class BandNameGenerator
    {
        public string GenerateBandName(string giveName)
        {
            var bandName = FirstCharToUpper(giveName);
            if (IsFirstCharEqualsTheLastChar(giveName))
            {
                bandName = Copy(giveName, bandName);
                return bandName;
            }

            return "The " + bandName;
        }

        public static string Copy(this string giveName, string bandName)
        {
            for (int i = 1; i < giveName.Length; i++)
            {
                bandName += giveName[i];
            }

            return bandName;
        }

        private static bool IsFirstCharEqualsTheLastChar(string giveName)
        {
            return giveName[0].Equals(giveName[giveName.Length - 1]);
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