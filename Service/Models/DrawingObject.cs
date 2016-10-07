

namespace TeamDraw 
{
    public abstract class DrawingObject
    {
        public string Name { get; set; }
        public abstract int GetMaxX();
        public abstract int GetMaxY();
    }    
}