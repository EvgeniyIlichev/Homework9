using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h5
{
    public partial class Program
    {
        //---------------Объявления----------------------------
        public static string text; //Переменна для вводимого текста
        public static List<string> words = new List<string>(); //Коллекция для слов
        public static string reverseSentence; //Переменная для предложения в обратном порядке
        
        //--------------Главныц метод--------------------------     
        static void Main(string[] args)
        {
            text = InputText(); //Ввели текст
            words = TextInWords(text); //Получили слова
            OutputWordsNewLine(words); //Вывели слова
            OutputReverseSentence(WordsInReverseSentence(words));//Вывод предложения
            Console.ReadKey(); //Пауза консоли
        }
        
        //--------------Ввод данных--------------------------     
        /// <summary>
        /// Метод ввода текста
        /// </summary>
        /// <returns></returns>
        public static string InputText()
        {
            text = Console.ReadLine();
            return text;
        }
        
        //--------------Преобразования--------------------------     
        /// <summary>
        /// Метод преобазования текста в коллекцию отдельных слов
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static List<string> TextInWords(string text)
        {
            string newWord = string.Empty; //переменная для нового слова
            char[] wordsChar = text.ToCharArray(); //массив вводимого текста преобразованного в символы
            bool charUp = false; //условие для определения индекса символа
            //Перебираем все символы в массиве
            for (int i = 0; i < wordsChar.Length; i++)
            {   //если символ пробел
                if (wordsChar[i] == ' ' )
                {   //проверяем не является новое слово пустым
                    if (newWord == string.Empty) continue;
                    else
                    {   //и если оно не пустое
                        words.Add(newWord); //добавляем в коллекцию
                        newWord = string.Empty; //делаем переменную пустой
                        charUp = false; //следующее слово с большой буквы
                        continue;
                    }
                }
                else
                {   
                    if (!charUp)
                    {
                        newWord += wordsChar[i].ToString().ToUpper();//делаем букву большой
                        charUp = true;
                    }
                    else
                    {
                        newWord += wordsChar[i].ToString().ToLower();//делаем букву маленькой
                    }
                    //доходя до конца массива добавляем новое слово в коллекцию
                    if (i == wordsChar.Length - 1)
                    {
                        words.Add(newWord);
                    }
                }
            }
            return words;
        }
         /// <summary>
         /// Преобразование вводимых слов в реверс предложение
         /// </summary>
         /// <param name="words"></param>
         /// <returns></returns>
        public static string WordsInReverseSentence(List<string> words)
        {
            words.Reverse();//реверс коллекции
            foreach (var word in words)
            {   //Первое слово в предложение будет с большой буквы
                if(word != words.First())
                {
                    reverseSentence += word.ToLower() + " ";
                }
                else
                {
                    reverseSentence += word + " ";
                }
            }
            return reverseSentence;
        }
        
        //--------------Вывод----------------------------------     
        /// <summary>
        /// Метод вывода коллекции в консоль(каждое слово с новой строчки)
        /// </summary>
        /// <param name="words"></param>
        public static void OutputWordsNewLine(List<string> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
        /// <summary>
        /// Метод вывода реверс предложения
        /// </summary>
        /// <param name="reverseSentence"></param>
        public static void OutputReverseSentence(string reverseSentence)
        {
            Console.WriteLine(reverseSentence);
        }
    }
}
