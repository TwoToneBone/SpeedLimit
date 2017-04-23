using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> outputs = new List<string>();

            while (true)
            {
                int subtractTime = 0;
                int distance = 0;

                int loop = int.Parse(Console.ReadLine());

                if (loop < 0)
                {
                    break;
                }

                for (int i = 0; i < loop; i++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    int speed = int.Parse(inputs[0]);
                    int time = int.Parse(inputs[1]);

                    int calcTime = time - subtractTime;
                    subtractTime = time;

                    distance += (speed * calcTime);

                }

                outputs.Add((distance.ToString() + " " + "Miles"));

            }
            foreach (var s in outputs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
