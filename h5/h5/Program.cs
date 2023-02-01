using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h5
{
    public partial class Program
    {
        public static string text;
        public static int countWords;
        public static List<string> words;
        static void Main(string[] args)
        {
            text = InputText();
            countWords = CountWords(text);
            words = WordsInText(text, countWords);
            WriteWordsNewLine(words);
            Console.ReadKey();
        }

        public static string InputText()
        {
            string text = Console.ReadLine();
            return text;
        }
        public static int CountWords(string text) 
        {
            int countWords = 0;
            char[] wordsChar = text.ToCharArray();
            for (int i = 0; i < wordsChar.Length; i++)
            {
                if (wordsChar[i] == ' ')
                {
                    countWords++;
                }
            }
            return countWords;
        }
        public static List<string> WordsInText(string text, int countWords)
        {
            string newLes = string.Empty;
            int countSpace = 0;
            List<string> words = new List<string>();
            string newWord = string.Empty;
            char[] wordsChar = text.ToCharArray();
            bool charUp = false;
            for (int i = 0; i < wordsChar.Length; i++)
            {
                if (wordsChar[i] == ' ' )
                {
                    words.Add(newWord);
                    newWord= string.Empty;
                    countSpace++;
                    charUp = false;
                    continue;
                }
                else
                {
                    if (!charUp)
                    {
                        newLes = wordsChar[i].ToString().ToUpper();
                        charUp = true;
                    }
                    else
                    {
                        newLes = wordsChar[i].ToString().ToLower();
                    }
                    newWord += newLes;
                    if (i == wordsChar.Length - 1)
                    {
                        words.Add(newWord);
                    }
                }
            }
            return words;
        }
        public static void WriteWordsNewLine(List<string> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
