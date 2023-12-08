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

namespace Guldmynt
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
            List<int[]> bags = new List<int[]>()
            {
                new int[]{ 11, 45, 8 },
                new int[]{ 72, 36, 94 },
                new int[]{ 50, 24 },
                new int[]{ 13, 38, 66 },
                new int[]{ 84, 81, 16 },
                new int[]{ 26, 17, 92 },
                new int[]{ 65, 95, 0 },
                new int[]{ 49, 1, 72 },
                new int[]{ 85, 35, 97 },
                new int[]{ 23 },
                new int[]{ 69, 47, 90 },
                new int[]{ 19, 70, 95 },
                new int[]{ 96, 58, 44 },
                new int[]{ 2, 5, 87 },
                new int[]{ 78, 51, 79 },
                new int[]{ 21, 9, 6 },
                new int[]{ 20, 19, 36 },
                new int[]{ 9, 79, 70 },
                new int[]{ 73, 24, 26 },
                new int[]{ 12, 51, 98 },
                new int[]{ 11, 18, 49 },
                new int[]{ 97, 85, 31 },
                new int[]{ 44, 18, 71 },
                new int[]{ 22, 51, 17 },
                new int[]{ 34, 2, 23 },
                new int[]{ 42, 27 },
                new int[]{ 41, 14, 52 },
                new int[]{ 43, 98, 79 },
                new int[]{ 67, 11, 79 },
                new int[]{ 35, 92, 62 },
                new int[]{ 82, 81, 20 },
                new int[]{ 64, 68, 16 },
                new int[]{ 10, 70, 65 },
                new int[]{ 3, 85, 23 },
                new int[]{ 23, 87 },
                new int[]{ 26, 64, 91 },
                new int[]{ 14, 66, 91 },
                new int[]{ 19, 65, 57 },
                new int[]{ 96, 48, 12 },
                new int[]{ 24, 49, 60 },
                new int[]{ 40, 76, 10 },
                new int[]{ 79, 15, 3 },
                new int[]{ 18, 5, 41 },
                new int[]{ 84, 21, 56 },
                new int[]{ 84, 94 },
                new int[]{ 31, 20, 84 },
                new int[]{ 79, 2, 56 },
                new int[]{ 63, 51, 21 }
            };
            int count = 0;
            int totalCoins = 0;
            int totalSum = 0;
            foreach (int[] bag in bags)
            {
                count++;
                int coinValue = 5;
                foreach (int coin in bag)
                {
                    totalCoins += coin;
                    totalSum += coin * coinValue;
                    coinValue <<= 1; // Om vi antar att det ökar på samma sätt för högre mynt
                }
            }
            MessageBox.Show($"{count} säckar med {totalCoins} mängd mynt värda totalt {totalSum}!");
        }
    }
}