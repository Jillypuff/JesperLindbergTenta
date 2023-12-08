using System.Windows;

namespace Taxering
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

        private void ButtonControll_Click(object sender, RoutedEventArgs e)
        {
            int monthlySalary = Int32.Parse(TextMonthlySalary.Text);
            int savings = Int32.Parse(TextSavedMoney.Text);            
            int totalYearlyWealth = monthlySalary * 12 + savings;

            int limitTooRich = 1_200_000;

            if (totalYearlyWealth >= limitTooRich)
            {
                MessageBox.Show("Karl-Bertil tar paketet");
            } 
            else
            {
                MessageBox.Show("Karl-Bertil lämnar tillbaka paketet till ägaren");
            }

        }


        private void ButtonControllPlus_Click(object sender, RoutedEventArgs e)
        {
            int savings = Int32.Parse(TextSavedMoney.Text);
            int interest = Int32.Parse(TextInterest.Text);
            int years = Int32.Parse(TextYears.Text);

            int totalBalance = CalculateBalance(savings, interest, years);
            MessageBox.Show($"Efter {years} år med {interest}% ränta så har {savings} blivit till {totalBalance}.");

        }
        int CalculateBalance(int savings, int interest, int years)
            //=> (int)Math.Round(savings * Math.Pow(1 + (double)interest / 100, years), 0);
        {
            double interestValue = 1 + (double)interest / 100;
            double interestAfterYears = Math.Pow(interestValue, years);
            double totalBalance = savings * interestAfterYears;

            return (int)Math.Round(totalBalance, 0);
        }
    }
}