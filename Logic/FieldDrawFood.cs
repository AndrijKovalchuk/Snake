namespace Logic
{
    public partial class Field
    {
        public void DrawFood(int x, int y, char Symbol)
        {
            this.Array[x,y] = Symbol;
        }
    }
}