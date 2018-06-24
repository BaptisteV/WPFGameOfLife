using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GameOfLife
{
    public class CellularSystem
    {
        public Brush DeadColor { get; set; }
        public Brush AliveColor { get; set; }
        public List<List<CellState>> Cells { get; set; }
        private int width;
        private int heigth;

        public CellularSystem(int width, int height)
        {
            this.width = width;
            this.heigth = height;
            AllCellsDead();
        }

        public void AllCellsDead()
        {
            Cells = new List<List<CellState>>();
            for (var i = 0; i < width; i++)
            {
                Cells.Add(new List<CellState>());
                for (var j = 0; j < heigth; j++)
                {
                    Cells[i].Add(CellState.Dead);
                }
            }
        }

        private List<CellState> SurrondingCells(int x, int y)
        {
            List<CellState> surrondings = new List<CellState>();
            
            if (Cells.ElementAtOrDefault(x - 1) != null && Cells[x].ElementAtOrDefault(y - 1) != default(CellState))
            {
                surrondings.Add(Cells[x - 1][y - 1]); // top left
            }
            if (Cells.ElementAtOrDefault(x) != null && Cells[x].ElementAtOrDefault(y - 1) != default(CellState))
            {
                surrondings.Add(Cells[x][y - 1]);  // top
            }
            if (Cells.ElementAtOrDefault(x + 1) != null && Cells[x].ElementAtOrDefault(y - 1) != default(CellState))
            {
                surrondings.Add(Cells[x + 1][y - 1]); // top right
            }
            if (Cells.ElementAtOrDefault(x + 1) != null && Cells[x].ElementAtOrDefault(y) != default(CellState))
            {
                surrondings.Add(Cells[x + 1][y]); // right
            }
            if (Cells.ElementAtOrDefault(x + 1) != null && Cells[x].ElementAtOrDefault(y + 1) != default(CellState))
            {
                surrondings.Add(Cells[x + 1][y + 1]); // bottom right
            }
            if (Cells.ElementAtOrDefault(x) != null && Cells[x].ElementAtOrDefault(y + 1) != default(CellState))
            {
                surrondings.Add(Cells[x][y + 1]); // bottom
            }
            if (Cells.ElementAtOrDefault(x - 1) != null && Cells[x].ElementAtOrDefault(y + 1) != default(CellState))
            {
                surrondings.Add(Cells[x - 1][y + 1]); // bottom left
            }
            if (Cells.ElementAtOrDefault(x - 1) != null && Cells[x].ElementAtOrDefault(y) != default(CellState))
            {
                surrondings.Add(Cells[x - 1][y]); // left
            }
            return surrondings;
        }

        public bool SetTo(Shape shape)
        {
            AllCellsDead();
            foreach(var aliveCell in shape.AliveCells)
            {
                if (Cells.ElementAtOrDefault(aliveCell.Item1) == null || Cells[aliveCell.Item1].ElementAtOrDefault(aliveCell.Item2) == default(CellState))
                {
                    return false;
                }
                Cells[aliveCell.Item1][aliveCell.Item2] = CellState.Alive;
            }
            return true;
        }

        private int CountSurrondingLivingCells(int x, int y)
        {
            return SurrondingCells(x, y).Where(p => p == CellState.Alive).Count();
        }
        public void NextGeneration()
        {
            var nextGen = new List<List<CellState>>();
            for (int i = 0; i < Cells.Count; i++)
            {
                nextGen.Add(new List<CellState>());
                for (int j = 0; j < Cells[i].Count; j++)
                {
                    var aliveSurrondingCellsCount = CountSurrondingLivingCells(i, j);
                    //Si une cellule a exactement trois voisines vivantes, elle est vivante à l’étape suivante.
                    if (aliveSurrondingCellsCount == 3)
                    {
                        nextGen[i].Add(CellState.Alive);
                        continue;
                    }
                    //Si une cellule a exactement deux voisines vivantes, elle reste dans son état actuel à l’étape suivante.
                    else if (aliveSurrondingCellsCount == 2)
                    {
                        nextGen[i].Add(Cells[i][j]);
                        continue;
                    }
                    //Si une cellule a strictement moins de deux ou strictement plus de trois voisines vivantes, elle est morte à l’étape suivante.
                    else if ((aliveSurrondingCellsCount < 2) || (aliveSurrondingCellsCount > 3))
                    {
                        nextGen[i].Add(CellState.Dead);
                        continue;
                    }
                    else
                    {
                        nextGen[i].Add(Cells[i][j]);
                    }
                }
            }
            Cells = nextGen;
        }
    }
}
