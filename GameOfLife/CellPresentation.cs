using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GameOfLife
{
    public class CellPresentation
    {
        public Tuple<int, int> Location;
        
        public Brush CellColor;

        public CellPresentation(Brush brush, Tuple<int, int> location)
        {
            Location = location;
            CellColor = brush;
        }
    }
}
