namespace Logic
{
    public partial class Snake
    {
        public int Size { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public char HeadSymbol { get; set; } = '1';
        public char BodySymbol { get; set; }
    }
}