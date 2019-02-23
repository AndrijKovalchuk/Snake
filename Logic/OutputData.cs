namespace Logic
{
    public class Data
    {
        public int FieldSize { get; set; } // It means square form of field.

        public char Direction { get; set; } // r - Right, l - Left, u - Up, d - Down.

        public int PlayerCordinateX { get; set; }

        public int PlayerCordinateY { get; set; }

        public int EnemyCordinateX { get; set; }
        public int EnemyCordinateY { get; set; }

    }
}