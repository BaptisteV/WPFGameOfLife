namespace GameOfLife
{
    public class ShapeFactory
    {
        public Shape GetNewShape(string name)
        {
            switch (name)
            {
                case "toad":
                    return new ToadShape();
                default:
                    throw new System.Exception("Unknown shape");
            }
        }
    }
}