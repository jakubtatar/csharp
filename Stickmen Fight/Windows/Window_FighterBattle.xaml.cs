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
using System.Windows.Shapes;

namespace Stickmen_Fight.Windows
{
    /// <summary>
    /// Interaction logic for Window_FighterBattle.xaml 
    /// </summary>
    public partial class Window_FighterBattle : Window
    {
        public GameEngine gameEngine {  get; set; } = new GameEngine();
        public Window_FighterBattle()
        {
            InitializeComponent();

            RefreshElements();
        }

        private void RefreshElements()
        {
            ProgressBar_Pokemon1_HP.Value = gameEngine.FirstFighter.health;
            Label_Pokemon1_HP.Content = gameEngine.FirstFighter.health + "/100";

            ProgressBar_Pokemon2_HP.Value = gameEngine.SecondFighter.health;
            Label_Pokemon2_HP.Content = gameEngine.SecondFighter.health + "/100";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damage = gameEngine.FirstFighter.Attack1();
            var pokemonSurvive = gameEngine.SecondFighter.TakeDamage(damage);
            RefreshElements();
        }

        private void Button_Pokemon1_HardAttack_Click(object sender, RoutedEventArgs e)
        {
            var damage = gameEngine.FirstFighter.Attack2();
            var pokemonSurvive = gameEngine.SecondFighter.TakeDamage(damage);
            RefreshElements();
        }

        private void Button_Pokemon1_Critical_Click(object sender, RoutedEventArgs e)
        {
            var damage = gameEngine.FirstFighter.Attack3();
            var pokemonSurvive = gameEngine.SecondFighter.TakeDamage(damage);
            RefreshElements();
        }
    }
}
