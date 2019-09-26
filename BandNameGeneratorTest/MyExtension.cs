namespace BandNameGeneratorTest
{
    public static class MyExtension
    {
        public static string CopyName(this string bandName, string giveName)
        {
            for (int i = 1; i < giveName.Length; i++)
            {
                bandName += giveName[i];
            }

            return bandName;
        }
    }
}