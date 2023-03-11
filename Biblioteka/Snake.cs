namespace Biblioteka
{
    public class Snake
    {
        private LinkedList<Segment> _body = new();

        public Snake(Point point)
        {
            var firstsegment = new Segment();
            firstsegment.Move(point);
            _body.AddFirst(firstsegment);
        }
        
        public IEnumerable<Point> Points()
        {
            foreach (var segment in _body)
            {
                
            }
        }
    }
}