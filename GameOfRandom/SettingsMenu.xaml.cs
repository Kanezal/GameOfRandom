using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameOfRandom
{
    /// <summary>
    /// Interaction logic for SettingsMenu.xaml
    /// </summary>
    public partial class SettingsMenu : UserControl
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RandomNumIntervalSlider.upperSlider.Maximum = 100;
            RandomNumIntervalSlider.upperSlider.Value = RandomNumIntervalSlider.upperSlider.Maximum;
            RandomNumIntervalSlider.upperSlider.Minimum = 0;

            RandomNumIntervalSlider.lowerSlider.Maximum = 100;
            RandomNumIntervalSlider.lowerSlider.Minimum = 0;
            RandomNumIntervalSlider.lowerSlider.Value = RandomNumIntervalSlider.lowerSlider.Minimum;

            UsebleNumsIntervalSlider.upperSlider.Maximum = 100;
            UsebleNumsIntervalSlider.upperSlider.Value = RandomNumIntervalSlider.upperSlider.Maximum;
            UsebleNumsIntervalSlider.upperSlider.Minimum = 0;

            UsebleNumsIntervalSlider.lowerSlider.Maximum = 100;
            UsebleNumsIntervalSlider.lowerSlider.Minimum = 0;
            UsebleNumsIntervalSlider.lowerSlider.Value = UsebleNumsIntervalSlider.lowerSlider.Minimum;
        }

        public event EventHandler ButtonClicked;
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            GameSettings settings = new GameSettings(
                RandomLowerValueText.Text, RandomUpperValueText.Text, UsebleLowerValueText.Text, UsebleUpperValueText.Text, PlayersCountText.Text);

            ButtonClicked?.Invoke(this, EventArgs.);
        }


        //private void SubmitButton_Click(object sender, RoutedEventArgs e)
        //{
        //    GameSettings settings = new GameSettings(
        //        RandomLowerValueText.Text, RandomUpperValueText.Text, UsebleLowerValueText.Text, UsebleUpperValueText.Text, PlayersCountText.Text);

        //    NavigationService navigationService = NavigationService.GetNavigationService(this);
        //    if (navigationService != null)
        //    {
        //        // Создайте экземпляр новой страницы
        //        GameCycle newPage = new GameCycle();

        //        // Перейдите на новую страницу
        //        navigationService.Navigate(newPage);
        //    }
        //}


        private void RandomNumIntervalSlider_MouseMove(object sender, MouseEventArgs e) { ChangeRandomNum(); }
        private void RandomNumIntervalSlider_PreviewKeyDown(object sender, KeyEventArgs e) { ChangeRandomNum(); }
        private void ChangeRandomNum()
        {
            if (RandomNumIntervalSlider.lowerSlider.Value < RandomNumIntervalSlider.upperSlider.Value)
            {
                RandomLowerValueText.Text = $"{(int)Math.Floor(RandomNumIntervalSlider.lowerSlider.Value)}";
                RandomUpperValueText.Text = $"{(int)Math.Floor(RandomNumIntervalSlider.upperSlider.Value)}";
            }
            else
            {
                RandomLowerValueText.Text = $"{(int)Math.Floor(RandomNumIntervalSlider.upperSlider.Value)}";
                RandomUpperValueText.Text = $"{(int)Math.Floor(RandomNumIntervalSlider.lowerSlider.Value)}";
            }
        }


        private void UsebleNumsIntervalSlider_MouseMove(object sender, MouseEventArgs e) { ChangeUsebleNums(); }
        private void UsebleNumsIntervalSlider_PreviewKeyDown(object sender, KeyEventArgs e) { ChangeUsebleNums(); }
        private void ChangeUsebleNums()
        {
            if (UsebleNumsIntervalSlider.lowerSlider.Value < UsebleNumsIntervalSlider.upperSlider.Value)
            {
                UsebleLowerValueText.Text = $"{(int)Math.Floor(UsebleNumsIntervalSlider.lowerSlider.Value)}";
                UsebleUpperValueText.Text = $"{(int)Math.Floor(UsebleNumsIntervalSlider.upperSlider.Value)}";
            }
            else
            {
                UsebleLowerValueText.Text = $"{(int)Math.Floor(UsebleNumsIntervalSlider.upperSlider.Value)}";
                UsebleUpperValueText.Text = $"{(int)Math.Floor(UsebleNumsIntervalSlider.lowerSlider.Value)}";
            }
        }
    }
}
