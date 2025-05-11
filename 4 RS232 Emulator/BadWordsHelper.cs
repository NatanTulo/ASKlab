using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4_RS232_Emulator.Helpers
{
    public static class BadWordsHelper
    {
        private static List<string> badWords = LoadBadWords();

        private static List<string> LoadBadWords()
        {
            string path = @"badwords.csv";
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                var words = new List<string>();
                foreach (var line in lines)
                {
                    words.AddRange(line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(w => w.Trim()));
                }
                return words;
            }
            return new List<string>();
        }

        public static string FilterWords(string text)
        {
            foreach (string word in badWords)
            {
                string pattern = Regex.IsMatch(word, @"^\w+$") ?
                    @"\b" + Regex.Escape(word) + @"\b" : Regex.Escape(word);
                text = Regex.Replace(text, pattern, new string('*', word.Length), RegexOptions.IgnoreCase);
            }
            return text;
        }
    }
}
