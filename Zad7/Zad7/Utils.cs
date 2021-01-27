using System;
using System.Collections.Generic;
using System.Text;

namespace Zad7
{
    class Utils
    {
        private const string ALPHABET = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const int LOWEST_MARK = 1;
        private const int BIGGEST_MARK = 6;
        private Random random;

        public Utils()
        {
            random = new Random();
        }

        public string GenerateName(int length)
        {
            StringBuilder name = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                name.Append(ALPHABET[random.Next(0, ALPHABET.Length)]);
            }

            return name.ToString();
        }

        public int[] GenerateMarks(int length)
        {
            int[] Marks = new int[length];

            for (int i = 0; i < Marks.Length; i++)
            {
                Marks[i] = random.Next(LOWEST_MARK, BIGGEST_MARK);
            }

            return Marks;
        }
    }
}
