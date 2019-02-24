namespace Logic
{
    public partial class Snake
    {
        public char Direction { get; set; }
        public char NextDirection { get; set;}
        public int Scores { get; set; }
        public int CordinateX { get; set; } = 20;
        public int NextCordinateX { get; set; }
        public int CordinateY { get; set; } = 20;
        public int NextCordinateY { get; set; }
    }
}