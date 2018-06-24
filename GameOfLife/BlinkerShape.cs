using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public class BlinkerShape : Shape
    {
        public BlinkerShape()
        {
            this.AliveCells = new List<Tuple<int, int>>();
            this.AliveCells.Add(new Tuple<int, int>(1, 2));
            this.AliveCells.Add(new Tuple<int, int>(2, 2));
            this.AliveCells.Add(new Tuple<int, int>(3, 2));
        }
    }
}