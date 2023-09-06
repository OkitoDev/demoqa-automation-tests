using System;
using System.Linq;

namespace Tests.Utils
{
    public static class RandomUtils
    {
        private static Random random = new Random();
        private const string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string numbers = "0123456789";

        public static string GetRandomString(int length, bool useLowercaseLetters = true, bool useUppercaseLetters = true, bool useNumbers = true)
        {
            string characters = (useUppercaseLetters ? uppercaseLetters : "") +
                                (useLowercaseLetters ? lowercaseLetters : "") +
                                (useNumbers ? numbers : "");

            return new string(Enumerable.Repeat(characters, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}