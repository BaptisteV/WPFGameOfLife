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

namespace GameOfLife
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameOfLifeGame game;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            game = new GameOfLifeGame(10, 10);
            game.UpdateEvent += updateUI;
            game.SetToToad();
        }

        private void DisplayGridTooSmallErrorMessage()
        {
            MessageBox.Show("The grid is too small for this shape", Title);
        }

        private void updateUI(object sender, EventArgs e)
        {
            // How to bind directly to CellPresentation.CellColor ?
            items.ItemsSource = game.displayList.Select(p => p.Select(i => i.CellColor));
        }

        private void toadButton_Click(object sender, RoutedEventArgs e)
        {
            if (!game.SetToToad())
            {
                DisplayGridTooSmallErrorMessage();
            }
        }

        private void nextGenerationButton_Click(object sender, RoutedEventArgs e)
        {
            game.UpdateToNextGen();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            game.StartGame();
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            game.StopGame();
        }

        private void speedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (game != null)
            {
                game.SetUpdateRate((int)e.NewValue);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var buttonTotalWidth = button.Margin.Left + button.Width + button.Margin.Right;
            var buttonTotalHeight = button.Margin.Top + button.Height + button.Margin.Bottom;

            Point point = Mouse.GetPosition(items);
            var x = (int)Math.Floor(point.X);
            var y = (int)Math.Floor(point.Y);

            x = (int)Math.Floor(x / buttonTotalWidth);
            y = (int)Math.Floor(y / buttonTotalHeight);

            game.ChangeCellState(new Tuple<int, int>(x, y));
        }

        private void killButton_Click(object sender, RoutedEventArgs e)
        {
            game.ClearGame();
        }

        private void wikiButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void refreshSizeButton_Click(object sender, RoutedEventArgs e)
        {
            var newSize = 10;
            if (int.TryParse(GridSizeTextBox.Text, out newSize))
            {
                game = new GameOfLifeGame(newSize, newSize);
                game.UpdateEvent += updateUI;
                updateUI(null, EventArgs.Empty);
            }
        }
    }
}
