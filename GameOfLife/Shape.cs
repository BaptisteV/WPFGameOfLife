using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public abstract class Shape
    {
        public List<Tuple<int, int>> AliveCells;
    }
}