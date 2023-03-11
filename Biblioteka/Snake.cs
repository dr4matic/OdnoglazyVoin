using System.Security.Cryptography.X509Certificates;

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
        public Snake(Point point, int count)
        {
            var firstsegment = new Segment();
            firstsegment.Move(point);
            var item = _body.AddFirst(firstsegment);
            // добавим еще два элемента что бы змея состояла из трех
            for (var i = 0; i < count; i++)
            {
                var segment = new Segment();
                point = point with { X = point.X - 10, Y = point.Y }; 
                segment.Move(point);
                item = _body.AddAfter(item, segment);
            }
        }
        public IEnumerable<Point> Points()
        {
            foreach (var segment in _body)
            {
                yield return segment.Position;
            }
        }
        public void Move(Point point)
        {
            var first = _body.First;
            do
            {
                point = first.Value.Move(point);
                first = first.Next;
            } while(first != null);
        }
    }
}