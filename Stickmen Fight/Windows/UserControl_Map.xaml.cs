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

namespace Stickmen_Fight.Windows
{
    /// <summary>
    /// Interaction logic for UserControl_Map.xaml
    /// </summary>
    public partial class UserControl_Map : UserControl
    {
        public UserControl_Map()
        {
            InitializeComponent();

            GenerateMap();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void GenerateMap()
        {
            Random rnd = new Random();  
            int numberOfEnemies = 3;

            for (int i = 0; i < 3; i++)
            {
                var positionX = rnd.Next(-300, 300);
                var positionY = rnd.Next(-300, 300);
                Button button = new Button();
                button.Width = 100;
                button.Height = 50;
                button.Content = "Enemy: " + i;
                button.Margin = new Thickness(positionX, positionY * i, 0, 0);

                Grid_Map.Children.Add(button);
            }
        }
    }
}
