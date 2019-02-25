using Algorithm;
using Newtonsoft.Json;

namespace Logic
{
    public class Game
    {        
        public void Start()
        {            
            Data DataOut = new Data();            
            MyAlgorithm algo = new MyAlgorithm();
            
            string input;
            string Output = JsonConvert.SerializeObject(DataOut);
            
            while(true)
            {
                input = algo.MakeMove(Output);
                Output = GetData(input);
            }
        }

        private string GetData(string input)
        {
            Data data = JsonConvert.DeserializeObject<Data>(input);

            Snake snake = new Snake();
            snake.DoStep(data.Direction);


            string a = "a";
            return a;
        }
    }
}