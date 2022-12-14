namespace Day3
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
            string alphabetLowerUpper = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int totalPriority = 0;

            Dictionary<char, int> priorities = new Dictionary<char, int>();
            
            for (int i = 0; i < alphabetLowerUpper.Length; i++)
            {
                priorities.Add(alphabetLowerUpper[i], i + 1);
            }

            for (int sack = 0; sack < input.Length; sack++)
            {
                int sackLen = input[sack].Length;

                string pouch1 = input[sack].Substring(0, sackLen / 2);
                string pouch2 = input[sack].Substring((sackLen / 2));

                foreach (char c in pouch1)
                {
                    if (pouch2.Contains(c) == true)
                    {
                        char sharedChar = c;
                        totalPriority += priorities[c];
                        break;
                    }
                }
            }

            Console.WriteLine("Part 1: " + totalPriority);
        }

        static void Part2(string[] input)
        {
            string alphabetLowerUpper = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int totalPriority = 0;

            Dictionary<char, int> priorities = new Dictionary<char, int>();

            for (int i = 0; i < alphabetLowerUpper.Length; i++)
            {
                priorities.Add(alphabetLowerUpper[i], i + 1);
            }

            for (int i = 0; i < input.Length; i += 3)
            {
                foreach (char c in input[i])
                {
                    if (input[i+1].Contains(c) == true && input[i+2].Contains(c) == true)
                    {
                        totalPriority += priorities[c];
                        break;
                    }
                }
            }
            Console.WriteLine("Part 2: " + totalPriority);
        }
    }
}