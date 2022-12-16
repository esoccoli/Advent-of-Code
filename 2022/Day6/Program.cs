namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("../../../input.txt");

            Part1(input);
            Part2(input);
        }

        static void Part1(string input)
        {
            int markerIndex = 0;

            for (int i = 0; i < input.Length - 4; i++)
            {
                string currSubStr = input.Substring(i, 4);

                int numPassedChecks = 0;

                for (int j = 0; j < currSubStr.Length; j++)
                {
                    if (currSubStr.IndexOf(currSubStr[j]) == currSubStr.LastIndexOf(currSubStr[j]))
                    {
                        numPassedChecks++;
                    }
                }

                if (numPassedChecks == currSubStr.Length)
                {
                    markerIndex = i + 4;
                    break;
                }
            }
            Console.WriteLine("Part 1: " + markerIndex);
        }

        static void Part2(string input)
        {
            int markerIndex = 0;

            for (int i = 0; i < input.Length - 14; i++)
            {
                string currSubStr = input.Substring(i, 14);

                int numPassedChecks = 0;

                for (int j = 0; j < currSubStr.Length; j++)
                {
                    if (currSubStr.IndexOf(currSubStr[j]) == currSubStr.LastIndexOf(currSubStr[j]))
                    {
                        numPassedChecks++;
                    }
                }

                if (numPassedChecks == currSubStr.Length)
                {
                    markerIndex = i + 14;
                    break;
                }
            }
            Console.WriteLine("Part 2: " + markerIndex);
        }
    }
}