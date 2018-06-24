using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public class PentadecathlonShape : Shape
    {
        public PentadecathlonShape()
        {
            this.AliveCells = new List<Tuple<int, int>>();
            // outer horizontal bars
            this.AliveCells.Add(new Tuple<int, int>(4, 3));
            this.AliveCells.Add(new Tuple<int, int>(5, 3));
            this.AliveCells.Add(new Tuple<int, int>(6, 3));
            this.AliveCells.Add(new Tuple<int, int>(5, 4));
            this.AliveCells.Add(new Tuple<int, int>(5, 5));
            this.AliveCells.Add(new Tuple<int, int>(4, 6));
            this.AliveCells.Add(new Tuple<int, int>(5, 6));
            this.AliveCells.Add(new Tuple<int, int>(6, 6));


            this.AliveCells.Add(new Tuple<int, int>(4, 8));
            this.AliveCells.Add(new Tuple<int, int>(5, 8));
            this.AliveCells.Add(new Tuple<int, int>(6, 8));
            this.AliveCells.Add(new Tuple<int, int>(4, 9));
            this.AliveCells.Add(new Tuple<int, int>(5, 9));
            this.AliveCells.Add(new Tuple<int, int>(6, 9));

            this.AliveCells.Add(new Tuple<int, int>(4, 11));
            this.AliveCells.Add(new Tuple<int, int>(5, 11));
            this.AliveCells.Add(new Tuple<int, int>(6, 11));
            this.AliveCells.Add(new Tuple<int, int>(5, 12));
            this.AliveCells.Add(new Tuple<int, int>(5, 13));
            this.AliveCells.Add(new Tuple<int, int>(4, 14));
            this.AliveCells.Add(new Tuple<int, int>(5, 14));
            this.AliveCells.Add(new Tuple<int, int>(6, 14));

        }
    }
}