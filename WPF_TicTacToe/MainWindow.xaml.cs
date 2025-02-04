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

namespace WPF_TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char LastPlayer { get; set; } = '〇';
        public char PlayerOne { get; set; } = '✕';
        public char PlayerTwo { get; set; } = '〇';
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ProcessClick(Button button)
        {
            var buttonContent = button.Content.ToString();
            if (buttonContent.Contains(PlayerOne) || buttonContent.Contains(PlayerTwo))
            {
                return;
            }

            if (LastPlayer == PlayerOne)
            {
                button.Content = PlayerTwo;
                LastPlayer = PlayerTwo;
            }
            else if (LastPlayer == PlayerTwo)
            {
                button.Content = PlayerOne;
                LastPlayer = PlayerOne;
            }

            var isWinner = CHeckWinner();
            if (isWinner)
            {
                var result = MessageBox.Show(messageBoxText: "Vyhral hrac: " + LastPlayer + ", chcete pokracovat?",
                    caption: "Pokracovat v hre",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    Button_0x0.Content = "";
                    Button_0x1.Content = "";
                    Button_0x2.Content = "";
                    Button_1x0.Content = "";
                    Button_1x1.Content = "";
                    Button_1x2.Content = "";
                    Button_2x0.Content = "";
                    Button_2x1.Content = "";
                    Button_2x2.Content = "";
                }
                else
                {
                    this.Close();
                }      
            }
        }


        private void Button_0x0_Click(object sender, RoutedEventArgs e)
        {
            ProcessClick(sender as Button);
        }

        public bool CHeckWinner()
        {
            var b_0x0 = Button_0x0.Content.ToString();
            var b_0x1 = Button_0x1.Content.ToString();
            var b_0x2 = Button_0x2.Content.ToString();
            var b_1x0 = Button_1x0.Content.ToString();
            var b_1x1 = Button_1x1.Content.ToString();
            var b_1x2 = Button_1x2.Content.ToString();
            var b_2x0 = Button_2x0.Content.ToString();
            var b_2x1 = Button_2x1.Content.ToString();
            var b_2x2 = Button_2x2.Content.ToString();

            //kontrola prveho stlpca
            if ((b_0x0 == b_0x1 && b_0x1 == b_0x2) && (b_0x0 != "" && b_0x1 != "" && b_0x2 != ""))
            {
                return true;
            }
            //kontrola druheho stlpca
            if ((b_1x0 == b_1x1 && b_1x1 == b_1x2) && (b_1x0 != "" && b_1x1 != "" && b_1x2 != ""))
            {
                return true;
            }
            //kontrola tretieho stlpca
            if ((b_2x0 == b_2x1 && b_2x1 == b_2x2) && (b_2x0 != "" && b_2x1 != "" && b_2x2 != ""))
            {
                return true;
            }

            //kontrola prveho riadku
            if ((b_0x0 == b_1x0 && b_1x0 == b_2x0) && (b_0x0 != "" && b_1x0 != "" && b_2x0 != ""))
            {
                return true;
            }

            //kontrola druheho riadku
            if ((b_0x1 == b_1x1 && b_1x1 == b_2x1) && (b_0x1 != "" && b_1x1 != "" && b_2x1 != ""))
            {
                return true;
            }

            //kontrola tretieho riadku
            if ((b_0x2 == b_1x2 && b_1x2 == b_2x2) && (b_0x2 != "" && b_1x2 != "" && b_2x2 != ""))
            {
                return true;
            }

            return false;
        }
    }
}