namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../input.txt");

            Part1(input);
        }

        static void Part1(string[] input)
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

            int indexElfMaxCals = 0;

            for (int elf = 0; elf < elves.Count; elf++)
            {
                if (elves[elf] > elves[indexElfMaxCals])
                {
                    indexElfMaxCals = elf;
                }
            }

            Console.WriteLine("Part 1: " + elves[indexElfMaxCals]);
        }
    }
}