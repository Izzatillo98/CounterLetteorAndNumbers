﻿namespace CounterLetteorAndNumber.Service
{
    internal class CounterServices
    {
        public static int GenerateDigits(string text)

        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
        public static int GenerateLetters(string text)

        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }
        public static int GenerateAll(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
