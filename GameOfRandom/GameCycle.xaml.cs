using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for GameCycle.xaml
    /// </summary>
    public partial class GameCycle : Page
    {
        public GameCycle()
        {
            InitializeComponent();
        }
    }

    public class GameSettings
    {
        public List<int> randomValueRange = new List<int>();
        public List<int> usebleValuesRange = new List<int>();
        public int playersCount;

        public GameSettings(
            string RandomLowerValueText,
            string RandomUpperValueText,
            string UsebleLowerValueText,
            string UsebleUpperValueText,
            string PlayersCountText
        )
        {
            int randomLowerValue = int.Parse(RandomLowerValueText);
            int randomUpperValue = int.Parse(RandomUpperValueText);
            int usebleLowerValue = int.Parse(UsebleLowerValueText);
            int usebleUpperValue = int.Parse(UsebleUpperValueText);
            playersCount = int.Parse(PlayersCountText);

            for(int i = randomLowerValue; i <= randomUpperValue; i++)
            {
                this.randomValueRange.Add(i);
            }

            for (int i = usebleLowerValue; i <= usebleUpperValue; i++)
            {
                this.usebleValuesRange.Add(i);
            }
        }
    }


}
