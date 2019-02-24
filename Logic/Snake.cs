namespace Logic
{
    public partial class Snake
    {
        public char Direction { get; set; }
        //public char NextDirection { get; set;}
        //public int Scores { get; set; }
        public int CordinateX { get; set; } = 1;
        public int NextCordinateX { get; set; } = 1;
        public int CordinateY { get; set; } = 1;
        public int NextCordinateY { get; set; } = 1;
        public char Ch = '1';
        private int _scores;
    }
}