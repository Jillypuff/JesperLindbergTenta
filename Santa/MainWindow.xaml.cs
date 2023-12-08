using System.Windows;

namespace Santa
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
            int presents = 181;
            double neededAmountRaindeers = Math.Ceiling((double)presents / 30 + 2);

            MessageBox.Show($"{presents} paket kräver {neededAmountRaindeers} renar.");

            int maxPresentsCarryingRaindeers = 6;
            int maxCarryPotential = maxPresentsCarryingRaindeers * 30;

            bool hasOverload = HasOverload(presents, maxCarryPotential);
            int amountOfOverload = CountOverload(presents, maxCarryPotential);

            if (hasOverload)
            {
                MessageBox.Show($"Släden är överlastad. Ta bort {amountOfOverload} paket.");
            }
        }

        static bool HasOverload(int presents, int maxCarryPotential)
            => presents > maxCarryPotential;


        static int CountOverload(int presents, int maxCarryPotential)
            => presents > maxCarryPotential ? presents - maxCarryPotential : 0;      
    }
}