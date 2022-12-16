namespace Day4
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
            int numCompleteOverlaps = 0;
            
            for (int line = 0; line < input.Length; line++)
            {
                string[] ranges = input[line].Split(",");

                string elfOne = ranges[0];
                string elfTwo = ranges[1];

                string[] elfOneBounds = elfOne.Split("-");
                string[] elfTwoBounds = elfTwo.Split("-");

                int elf1Lower = int.Parse(elfOneBounds[0]);
                int elf1Upper = int.Parse(elfOneBounds[1]);

                int elf2Lower = int.Parse(elfTwoBounds[0]);
                int elf2Upper = int.Parse(elfTwoBounds[1]);

                if (elf2Lower >= elf1Lower && elf1Upper >= elf2Upper)
                {
                    numCompleteOverlaps++;
                }
                else if (elf1Lower >= elf2Lower && elf2Upper >= elf1Upper)
                {
                    numCompleteOverlaps++;
                }
            }
            Console.WriteLine("Part 1: " + numCompleteOverlaps);
        }

        static void Part2(string[] input)
        {
            int numOverlaps = 0;

            for (int line = 0; line < input.Length; line++)
            {
                string[] ranges = input[line].Split(",");

                string elfOne = ranges[0];
                string elfTwo = ranges[1];

                string[] elfOneBounds = elfOne.Split("-");
                string[] elfTwoBounds = elfTwo.Split("-");

                int elf1Lower = int.Parse(elfOneBounds[0]);
                int elf1Upper = int.Parse(elfOneBounds[1]);

                int elf2Lower = int.Parse(elfTwoBounds[0]);
                int elf2Upper = int.Parse(elfTwoBounds[1]);

                if (elf1Upper >= elf2Lower && elf1Upper <= elf2Upper)
                {
                    numOverlaps++;
                }
                else if (elf2Upper >= elf1Lower && elf2Upper <= elf1Upper)
                {
                    numOverlaps++;
                }
            }
            Console.WriteLine("Part 2: " + numOverlaps);
        }
    }
}