using System;


namespace Algorithm
{
    public interface UserAlgorithm
    {
        void SetGameField(char[,] Field);
        Move GetMove();
    }
}
