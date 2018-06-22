using System.Collections.Generic;

namespace GameOfLife
{
    public class ToadShape : Shape ,ICreateShape
    {
        public Shape CreateShape(string name)
        {
            ShapeCells[1] = new List<CellState>();
            ShapeCells[1][2] = CellState.Alive;
            ShapeCells[2] = new List<CellState>();
            ShapeCells[2][2] = CellState.Alive;
            ShapeCells[2][1] = CellState.Alive;
            ShapeCells[3] = new List<CellState>();
            ShapeCells[3][2] = CellState.Alive;
            ShapeCells[3][1] = CellState.Alive;
            ShapeCells[4] = new List<CellState>();
            ShapeCells[4][1] = CellState.Alive;
            return this;
        }
    }
}