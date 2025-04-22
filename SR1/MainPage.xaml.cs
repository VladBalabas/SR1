using System;
using Xamarin.Forms;

namespace SR1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (int.TryParse(EntryA.Text, out int a) && int.TryParse(EntryB.Text, out int b))
            {
                int result = Calculation.CalculateSum(a, b);
                ResultLabel.Text = $"Результат: {result}";
            }
            else
            {
                ResultLabel.Text = "Будь ласка, введіть коректні числа для [a, b].";
            }
        }

        private void OnCubesSumClicked(object sender, EventArgs e)
        {
            if (int.TryParse(EntryX1.Text, out int x1) &&
                int.TryParse(EntryX2.Text, out int x2) &&
                int.TryParse(EntryX3.Text, out int x3))
            {
                int result = Calculation.SumOfCubesDivisibleBy7(x1, x2, x3);
                CubeSumLabel.Text = $"Сума кубів (кратних 7): {result}";
            }
            else
            {
                CubeSumLabel.Text = "Введіть усі три числа коректно.";
            }
        }
    }
}
