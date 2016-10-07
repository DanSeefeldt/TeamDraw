using System;

namespace TeamDraw 
{
    public class Line : DrawingObject
    {
        public Line(int x1, int y1, int x2, int y2, string color)
        {
            this.Name = "Line";
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
            this.Color = color;
        }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public string Color { get; set; }

        public override int GetMaxX()
        {
            return Math.Max(X1, X2);
        }
        public override int GetMaxY()
        {
            return Math.Max(Y1, Y2);
        }
    }    
}