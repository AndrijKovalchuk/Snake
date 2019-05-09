namespace UI
{
    using System;
    using Logic;
    using Newtonsoft.Json;
    using static System.Console;

    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("I'm started");
            Game.Start();

            Read();
        }
    }
}
