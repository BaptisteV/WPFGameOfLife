using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public interface IRepository
    {
        void SaveSettings(GolGameSettings settings);
        GolGameSettings GetSettings();
    }
}
