namespace Logic
{
    public partial class Field 
    {
        public int Size { get; set;} = 20;
        public char[,] Array = new char[20, 20];
        public int StartCordinateX { get; set; } = 1;
        public int StartCordinateY { get; set; } = 1;
        private char OpenSymbol { get; set; } = '+';
        
    }
}