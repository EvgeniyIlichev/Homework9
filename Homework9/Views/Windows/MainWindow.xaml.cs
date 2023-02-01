using System.Windows;

namespace Homework9
{
    public partial class MainWindow : Window
    {
        public static string inputText;

        public MainWindow()
        {
            InitializeComponent();
            inputText = inputTextBlock.Text;
        }

    }
}
