using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public class PulsarShape : Shape
    {
        public PulsarShape()
        {
            this.AliveCells = new List<Tuple<int, int>>();
            // outer horizontal bars
            this.AliveCells.Add(new Tuple<int, int>(4, 2));
            this.AliveCells.Add(new Tuple<int, int>(5, 2));
            this.AliveCells.Add(new Tuple<int, int>(6, 2));

            this.AliveCells.Add(new Tuple<int, int>(10, 2));
            this.AliveCells.Add(new Tuple<int, int>(11, 2));
            this.AliveCells.Add(new Tuple<int, int>(12, 2));

            this.AliveCells.Add(new Tuple<int, int>(4, 14));
            this.AliveCells.Add(new Tuple<int, int>(5, 14));
            this.AliveCells.Add(new Tuple<int, int>(6, 14));

            this.AliveCells.Add(new Tuple<int, int>(10, 14));
            this.AliveCells.Add(new Tuple<int, int>(11, 14));
            this.AliveCells.Add(new Tuple<int, int>(12, 14));

            // inner horizontal bars
            this.AliveCells.Add(new Tuple<int, int>(4, 7));
            this.AliveCells.Add(new Tuple<int, int>(5, 7));
            this.AliveCells.Add(new Tuple<int, int>(6, 7));

            this.AliveCells.Add(new Tuple<int, int>(10, 7));
            this.AliveCells.Add(new Tuple<int, int>(11, 7));
            this.AliveCells.Add(new Tuple<int, int>(12, 7));

            this.AliveCells.Add(new Tuple<int, int>(4, 9));
            this.AliveCells.Add(new Tuple<int, int>(5, 9));
            this.AliveCells.Add(new Tuple<int, int>(6, 9));

            this.AliveCells.Add(new Tuple<int, int>(10, 9));
            this.AliveCells.Add(new Tuple<int, int>(11, 9));
            this.AliveCells.Add(new Tuple<int, int>(12, 9));

            // outer vertical bars
            this.AliveCells.Add(new Tuple<int, int>(2, 4));
            this.AliveCells.Add(new Tuple<int, int>(2, 5));
            this.AliveCells.Add(new Tuple<int, int>(2, 6));

            this.AliveCells.Add(new Tuple<int, int>(2, 10));
            this.AliveCells.Add(new Tuple<int, int>(2, 11));
            this.AliveCells.Add(new Tuple<int, int>(2, 12));

            this.AliveCells.Add(new Tuple<int, int>(14, 4));
            this.AliveCells.Add(new Tuple<int, int>(14, 5));
            this.AliveCells.Add(new Tuple<int, int>(14, 6));

            this.AliveCells.Add(new Tuple<int, int>(14, 10));
            this.AliveCells.Add(new Tuple<int, int>(14, 11));
            this.AliveCells.Add(new Tuple<int, int>(14, 12));

            // inner vertical bars
            this.AliveCells.Add(new Tuple<int, int>(7, 4));
            this.AliveCells.Add(new Tuple<int, int>(7, 5));
            this.AliveCells.Add(new Tuple<int, int>(7, 6));

            this.AliveCells.Add(new Tuple<int, int>(7, 10));
            this.AliveCells.Add(new Tuple<int, int>(7, 11));
            this.AliveCells.Add(new Tuple<int, int>(7, 12));

            this.AliveCells.Add(new Tuple<int, int>(9, 4));
            this.AliveCells.Add(new Tuple<int, int>(9, 5));
            this.AliveCells.Add(new Tuple<int, int>(9, 6));

            this.AliveCells.Add(new Tuple<int, int>(9, 10));
            this.AliveCells.Add(new Tuple<int, int>(9, 11));
            this.AliveCells.Add(new Tuple<int, int>(9, 12));
        }
    }
}