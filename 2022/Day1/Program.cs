namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../input.txt");

            List<int> elves = FindCalsAllElves(input);

            int maxCals = elves[0];
            for (int i = 0; i < elves.Count; i++)
            {
                if (elves[i] > maxCals)
                {
                    maxCals = elves[i];
                }
            }

            Console.WriteLine("Part 1: " + maxCals);

            // Part 2

            int sumTop3 = maxCals;

            int secondMax = 0;

            for (int i = 0; i < elves.Count; i++)
            {
                if (elves[i] > secondMax && elves[i] < maxCals)
                {
                    secondMax = elves[i];
                }
            }

            sumTop3 += secondMax;

            int thirdMax = 0;

            for (int i = 0; i < elves.Count; i++)
            {
                if (elves[i] > thirdMax && elves[i] < secondMax)
                {
                    thirdMax = elves[i];
                }
            }

            sumTop3 += thirdMax;

            Console.WriteLine("Part 2: " + sumTop3);
        }

        static List<int> FindCalsAllElves(string[] input)
        {
            List<int> elves = new List<int>();
            int calsCarrying = 0;

            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i] != "")
                {
                    calsCarrying += int.Parse(input[i]);
                }
                else
                {
                    elves.Add(calsCarrying);
                    calsCarrying = 0;
                }
            }

            return elves;
        }
    }
}