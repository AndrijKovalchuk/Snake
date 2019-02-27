namespace Logic
{
    public class Data
    {
        public int FieldSize { get; set; } = 20; // It means square form of field.

        public char Direction { get; set; } = 'u'; // r - Right, l - Left, u - Up, d - Down.

        public int PlayerCordinateX { get; set; } = 1;

        public int PlayerCordinateY { get; set; } = 1;

        public int EnemyCordinateX { get; set; } = 5;
        public int EnemyCordinateY { get; set; } = 5;

    }
}