namespace Logic
{
    public partial class Field
    {
        public void DrawClean()
        {
            for(int i = 0; i < this.Size; i++)
            {
                for(int j = 0; j < this.Size; j++)
                {
                    this.Array[ i, j] = this.OpenSymbol;
                }
            }
        }
    }
}