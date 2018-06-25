using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameOfLife
{
    /// <summary>
    /// Logique d'interaction pour CellColorPicker.xaml
    /// </summary>
    public partial class CellColorPicker : Window
    {
        private GolGameSettings settings;
        public CellColorPicker()
        {
            InitializeComponent();
        }
        public CellColorPicker(GolGameSettings settings)
        {
            InitializeComponent();
            this.settings = settings;
        }
        private void AliveColorSelector_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if(e.NewValue != null)
            {
                //settings.AliveColor = new SolidColorBrush((Color)e.NewValue);
            }
        }

        private void DeadColorSelector_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (e.NewValue != null)
            {
                //settings.DeadColor = new SolidColorBrush((Color)e.NewValue);
            }
        }
    }
}
