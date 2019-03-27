using System;
using Logic;
using Newtonsoft.Json;
using static System.Console;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("I'm started"); 
            Game.Start();
            
            Read();
        }
    }
}
