using Accessibility;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bonus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            string baubles = "bgrgbbgbrgrgrrgbrbrbgrgrbrgbbgrbbrgrgbrgbrbgrbrbgrgrgbrgbrbgrrgbrgrgrbgrbgbrgbrgrbrbgrgbrgbrbgrb";
            int red = 0;
            int blue = 0;
            int green = 0;
            foreach (char c in baubles)
            {
                switch (c)
                {
                    case 'r':
                        red++;
                        break;
                    case 'b':
                        blue++;
                        break;
                    case 'g':
                        green++;
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }

            int incorrectBaubles = CountIncorrectBaubles(baubles);
            MessageBox.Show($"Röda kulor:\t{red}\nBlåa kulor:\t{blue}\nGröna kulor:\t{green}\nMusse ogillar {incorrectBaubles} kulor.");
        }

        int CountIncorrectBaubles(string baubles)
        {
            int incorrectBaubles = 0;
            char previousBauble = baubles[0];
            char currentBauble = ' ';
            for(int i = 1; i < baubles.Length; i++)
            {
                currentBauble = baubles[i];
                if (previousBauble == currentBauble)
                {
                    incorrectBaubles++;
                }
                previousBauble = currentBauble;
            }

            return incorrectBaubles;
        }
    }
}