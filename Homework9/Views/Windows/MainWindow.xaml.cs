using h5;
using Homework9.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Homework9
{
    public partial class MainWindow : Window
    {

        List<string> InputWords { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetWords(object sender, RoutedEventArgs e)
        {
            result.Items.Clear();
            InputWords = Program.TextInWords(inputTextBlock.Text);
            foreach (var word in InputWords)
            {
                result.Items.Add(word);
            }

        }
    }
}
