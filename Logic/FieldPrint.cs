using System;

namespace Logic
{
    public partial class Field
    {
        public void Print()
        {
            for(int i = this.Size - 1; i >= 0; i--)
            {
                for(int j = 0; j < this.Size; j++)
                {
                    Console.Write(this.Array[i,j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}