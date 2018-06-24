using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace GameOfLife
{
    public class GameOfLifeGame
    {

        private DispatcherTimer updateLoop;
        public event EventHandler UpdateEvent;

        public List<List<CellPresentation>> displayList
        {
            get
            {
                var system = cellularSys.Cells;
                var result = new List<List<CellPresentation>>();

                for (var i = 0; i < system.Count; i++)
                {
                    result.Add(new List<CellPresentation>());
                    for (var j = 0; j < system[i].Count; j++)
                    {
                        var brush = system[i][j] == CellState.Alive ? cellularSys.AliveColor : cellularSys.DeadColor;
                        result[i].Add(new CellPresentation(brush, new Tuple<int, int>(i, j)));
                    }
                }
                return result;
            }
        }
        
        private CellularSystem cellularSys;

        public GameOfLifeGame(int width, int height)
        {
            cellularSys = new CellularSystem(width, height);
            cellularSys.AliveColor = new SolidColorBrush(Colors.Yellow);
            cellularSys.DeadColor = new SolidColorBrush(Colors.LightBlue);
            
            updateLoop = new DispatcherTimer();
            updateLoop.Interval = new TimeSpan(0, 0, 0, 0, 300);
            updateLoop.Tick += UpdateLoop_Tick;
        }

        private void UpdateLoop_Tick(object sender, EventArgs e)
        {
            UpdateToNextGen();
        }

        public void StartGame()
        {
            updateLoop.Start();
        }

        public void SetUpdateRate(int value)
        {
            updateLoop.Interval = new TimeSpan(0, 0, 0, 0, value);
        }

        public void ChangeCellState(Tuple<int,int> location)
        {
            cellularSys.Cells[location.Item2][location.Item1] = cellularSys.Cells[location.Item2][location.Item1] == CellState.Alive ? CellState.Dead : CellState.Alive;
            UpdateEvent(null, EventArgs.Empty);
        }

        public void StopGame()
        {
            updateLoop.Stop();
        }

        public void ClearGame()
        {
            cellularSys.AllCellsDead();
            UpdateEvent(null, EventArgs.Empty);
        }

        
        public void UpdateToNextGen()
        {
            cellularSys.NextGeneration();
            UpdateEvent(null, EventArgs.Empty);
        }

        public bool SetTo(Shape shape)
        {
            var result = cellularSys.SetTo(shape);
            UpdateEvent(null, EventArgs.Empty);
            return result;
        }

    }
}
