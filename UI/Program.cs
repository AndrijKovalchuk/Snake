using System;
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

            Field field = new Field();

            Test();

            //Enter direction char, In this place must be algorithm function
            // and she must return char; r - Right, l - Left, u - Up, d - Down.
            field.DoMove('d'); 

            WriteLine("\n");
            PrintResult(field.GameField);            
            
            WriteLine("\nPress Enter to exit.");
            Read();
        }

        static void Test()
        {
            Field field = new Field();
            field.InitField();

            string Output = JsonConvert.SerializeObject(field);

            Field DeserealizedOutput = JsonConvert.DeserializeObject<Field>(Output);

            PrintResult(DeserealizedOutput.GameField);
            
        }

        //Print result array
        static void PrintResult(char[,] temp)
        {
            for(int i = 19; i >= 0; i--)
            {
                for(int j = 0; j < 20; j++)
                {
                    Write(Convert.ToChar(temp[i, j]) + " ");
                }
                Write("\n");
            }
        }
    }
}
