namespace Biblioteka
{
    public class Segment
    {
        public Point Position { get; private set; } = new Point(0, 0);

        public Point Move(Point point)
        {
            Point t = Position;
            Position = point;
            return t;
        }
    }
}