using System;

namespace DZ_7
{
    public class ACoder : ICoder
    {
        private readonly char[] CharArray;

        public ACoder(string inputString)
        {
            CharArray = inputString.ToCharArray();
        }

        public string Decode()
        {
            for (int i = 0; i < CharArray.Length; i++)
            {
                CharArray[i] = (char)(CharArray[i] - 1);
            }

            return string.Concat(CharArray);
        }

        public string Encode()
        {
            for (int i = 0; i < CharArray.Length; i++)
            {
                CharArray[i] = (char)(CharArray[i] + 1);
            }

            return string.Concat(CharArray);
        }
    }
}
