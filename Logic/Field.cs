namespace Logic
{
    public partial class Field 
    {
        public int FieldSize { get; set;} = 20;
        public char[,] GameField = new char[20, 20];
        private int StartCordinateX { get; set; } = 1;
        private int StartCordinateY { get; set; } = 1;
        
    }
}