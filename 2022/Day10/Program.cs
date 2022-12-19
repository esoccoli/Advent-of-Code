namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../input.txt");

            Part1(input);
            Part2(input);
        }

        static void Part1(string[] input)
        {
            int result = 0;

            List<int> signals = new List<int>();
            int signalStrength = 1;
            int currCycle = 1;
            for (int line = 0; line < input.Length; line++)
            {
                if (input[line].Equals("noop"))
                {
                    currCycle++;
                }
                else if (input[line].StartsWith("addx"))
                {
                    string[] parts = input[line].Split(" ");

                    currCycle++;

                    if (currCycle == 20 || currCycle == 60 || currCycle == 100 || currCycle == 140 || currCycle == 180 || currCycle == 220)
                    {
                        signals.Add(signalStrength * currCycle);
                    }

                    currCycle++;

                    signalStrength += int.Parse(parts[1]);
                }

                if (currCycle == 20 || currCycle == 60 || currCycle == 100 || currCycle == 140 || currCycle == 180 || currCycle == 220)
                {
                    signals.Add(signalStrength * currCycle);
                }
            }

            for (int i = 0; i < signals.Count; i++)
            {
                result+= signals[i];
            }
            Console.WriteLine("Part 1: " + result);
        }

        static void Part2(string[] input)
        {
            Console.WriteLine("Part 2: " + "not happening");
        }
    }
}