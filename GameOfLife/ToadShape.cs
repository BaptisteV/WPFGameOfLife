using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public class ToadShape : Shape
    {
        public ToadShape()
        {
            this.AliveCells = new List<Tuple<int, int>>();
            this.AliveCells.Add(new Tuple<int, int>(1, 2));
            this.AliveCells.Add(new Tuple<int, int>(2, 2));
            this.AliveCells.Add(new Tuple<int, int>(3, 2));
            this.AliveCells.Add(new Tuple<int, int>(2, 1));
            this.AliveCells.Add(new Tuple<int, int>(3, 1));
            this.AliveCells.Add(new Tuple<int, int>(4, 1));
        }
    }
}