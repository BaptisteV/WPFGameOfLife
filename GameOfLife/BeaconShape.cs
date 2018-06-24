using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public class BeaconShape : Shape
    {
        public BeaconShape()
        {
            this.AliveCells = new List<Tuple<int, int>>();
            this.AliveCells.Add(new Tuple<int, int>(1, 2));
            this.AliveCells.Add(new Tuple<int, int>(1, 1));
            this.AliveCells.Add(new Tuple<int, int>(2, 1));

            this.AliveCells.Add(new Tuple<int, int>(4, 3));
            this.AliveCells.Add(new Tuple<int, int>(4, 4));
            this.AliveCells.Add(new Tuple<int, int>(3, 4));
        }
    }
}