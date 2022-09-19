using System;
using System.Collections.Generic;

namespace DZ_7
{
    public class BCoder : ICoder
    {
        private readonly Dictionary<char, Tuple<int, int>> letters = new Dictionary<char, Tuple<int, int>>();

        private readonly char[] CharArray;

        private const int ruAlphabetLength = 32;
        private const int enAlphabetLength = 26;

        public BCoder(string text)
        {
            CharArray = text.ToCharArray();

            for (int i = 0; i < ruAlphabetLength; i++)
            {
                letters.Add((char)(1072 + i), new Tuple<int, int>(1072, 1072 + ruAlphabetLength - 1));
                letters.Add((char)(1040 + i), new Tuple<int, int>(1040, 1040 + ruAlphabetLength - 1));

                if (i < enAlphabetLength)
                {
                    letters.Add((char)(97 + i), new Tuple<int, int>(97, 97 + enAlphabetLength - 1));
                    letters.Add((char)(65 + i), new Tuple<int, int>(65, 65 + enAlphabetLength - 1));
                }
            }
        }

        public string Encode()
        {
            for (int i = 0; i < CharArray.Length; i++)
            {
                if (letters.ContainsKey(CharArray[i]))
                {
                    var el = letters[CharArray[i]];
                    CharArray[i] = (char)(el.Item2 - (CharArray[i] - el.Item1));
                }
                else
                {
                    CharArray[i] = CharArray[i];
                }
            }
            return string.Concat(CharArray);
        }

        public string Decode()
        {
            for (int i = 0; i < CharArray.Length; i++)
            {
                if (letters.ContainsKey(CharArray[i]))
                {
                    var el = letters[CharArray[i]];
                    CharArray[i] = (char)(el.Item2 - (CharArray[i] - el.Item1));
                }
                else
                {
                    CharArray[i] = CharArray[i];
                }
            }
            return string.Concat(CharArray);
        }
    }
}