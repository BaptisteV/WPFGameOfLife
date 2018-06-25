using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GameOfLife
{
    public class Repository : IRepository
    {
        [Serializable]
        private class SerializableGolSettings
        {
            public List<byte[]> Colors;
            public SerializableGolSettings(List<byte[]> colors)
            {
                this.Colors = colors;
            }
        }
        public GolGameSettings GetSettings()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = null;
            SerializableGolSettings result = null;
            try
            {
                stream = new FileStream("settings.bin", FileMode.Open, FileAccess.Read);
                result = (SerializableGolSettings)formatter.Deserialize(stream);
            }
            catch (FileNotFoundException e)
            {
                #if DEBUG
                    //throw e;
#endif
                return null;
            }
            var aliveRGBA = result.Colors[0];
            var deadRGBA = result.Colors[1];

            var settings = new GolGameSettings() {
                AliveColor = new SolidColorBrush(Color.FromArgb(aliveRGBA[3], aliveRGBA[0], aliveRGBA[1], aliveRGBA[2])),
                DeadColor = new SolidColorBrush(Color.FromArgb(deadRGBA[3], deadRGBA[0], deadRGBA[1], deadRGBA[2]))
            };
            stream.Close();
            return settings;
        }

        public void SaveSettings(GolGameSettings settings)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("settings.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            /*formatter.Serialize(stream, new SerializableGolSettings(new List<byte[]>()) {
                new byte[] { settings.AliveColor.Color.R, settings.AliveColor.Color.G }
            });*/
            var settingsToPersist = new SerializableGolSettings(new List<byte[]>() {
                new byte[]
            {
                settings.AliveColor.Color.R,
                settings.AliveColor.Color.G,
                settings.AliveColor.Color.B,
                settings.AliveColor.Color.A
            },
            new byte[]
            {
                settings.DeadColor.Color.R,
                settings.DeadColor.Color.G,
                settings.DeadColor.Color.B,
                settings.DeadColor.Color.A
            }
            });
            formatter.Serialize(stream, settingsToPersist);
            stream.Close();
        }

    }
}
