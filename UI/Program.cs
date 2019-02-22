using System;
using API;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm started");
            Class1 api = new Class1();
            api.SetState();
            Console.Read();
        }
    }
}
