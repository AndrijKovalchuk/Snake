﻿using System;
using Logic;
using Algorithm;
using Newtonsoft.Json;
using static System.Console;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("I'm started");

            Data data = new Data();
            data.Direction = 'u'; // r - Right, l - Left, u - Up, d - Down.
            data.FieldSize = 99;
            data.PlayerCordinateX = 10;
            data.PlayerCordinateY = 10;

            string Output = JsonConvert.SerializeObject(data);

            Data DeserealizedOutput = JsonConvert.DeserializeObject<Data>(Output);

            WriteLine("\nSerialized Output Data:");
            WriteLine(Output);

            WriteLine("\nDeserialized Output Data:");
            WriteLine(DeserealizedOutput.FieldSize);
            WriteLine(DeserealizedOutput.Direction);
            WriteLine(DeserealizedOutput.PlayerCordinateX);
            WriteLine(DeserealizedOutput.PlayerCordinateY);
            WriteLine("\nPress Enter to exit.");
            Read();
        }
    }
}
