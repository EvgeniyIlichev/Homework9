using h5;
using Homework9.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Homework9
{
    public partial class MainWindow : Window
    {

        List<string> inputWords { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка разделение текста на слова
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetWords(object sender, RoutedEventArgs e)
        {
            result.Items.Clear();
            inputWords = Program.TextInWords(inputTextGetWords.Text);
            foreach (var word in inputWords)
            {
                result.Items.Add(word);
            }

        }
        /// <summary>
        /// Кнопка создания реверс предложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReverseSentence(object sender, RoutedEventArgs e)
        {
            sentence.Text = string.Empty;
            inputWords = Program.TextInWords(inputTextGetReverse.Text);
            sentence.Text = Program.WordsInReverseSentence(inputWords);
        }
    }
}
