using System.Windows.Media;

namespace GameOfLife
{
    public class GolGameSettings
    {
        public SolidColorBrush AliveColor { get; internal set; }
        public SolidColorBrush DeadColor { get; internal set; }

        public GolGameSettings()
        {
            AliveColor = new SolidColorBrush(Colors.LightBlue);
            DeadColor = new SolidColorBrush(Colors.LightYellow);
        }
    }
}