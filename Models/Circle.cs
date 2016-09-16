

namespace TeamDraw 
{
    public class Circle : DrawingObject
    {
        public Circle(int x, int y, int radius, string color)
        {
            this.Name = "Circle";
            this.X = x;
            this.Y = y;
            this.Radius = radius;
            this.Color = color;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public string Color { get; set; }

        public override int GetMaxX()
        {
            return X + Radius;
        }
        public override int GetMaxY()
        {
            return Y + Radius;
        }
    }
    
}