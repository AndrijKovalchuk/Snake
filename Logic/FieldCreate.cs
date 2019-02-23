using System;
using static System.Console;

namespace Logic
{
    public partial class Field
    {
        public void FieldCreate()
        {
            Write("Please enter Field's size: ");
            
            this.FieldSize = Convert.ToInt32(Read());
            
        }
    }
}