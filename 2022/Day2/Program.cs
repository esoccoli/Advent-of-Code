namespace Day2
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
            // Rock: A, X
            // Paper: B, Y
            // Scissors: C, Z

            // SCORES:
            // Win = 6, Tie = 3, Loss = 0
            // Rock = 1, Paper = 2, Scissors = 3
            int totalScore = 0;


            for (int round = 0; round < input.Length; round++)
            {
                string[] choices = input[round].Split(' ');

                string oppChoice = choices[0];
                string yourChoice = choices[1];

                // Hard coding the possible outcomes

                if (oppChoice == "A") // rock
                {
                    if (yourChoice == "X") // rock
                    {
                        totalScore += 4; // 1 + 3 (rock, tie)
                    }
                    else if (yourChoice == "Y") // paper
                    {
                        totalScore += 8; // 2 + 6 (paper, win)
                    }
                    else // scissors
                    {
                        totalScore += 3; // 3 + 0 (scissors, lose)
                    }
                }

                else if (oppChoice == "B") // paper
                {
                    if (yourChoice == "X") // rock
                    {
                        totalScore += 1; // 1 + 0 (rock, loss)
                    }
                    else if (yourChoice == "Y") // paper
                    {
                        totalScore += 5; // 2 + 3 (paper, tie)
                    }
                    else // scissors
                    {
                        totalScore += 9; // 3 + 6 (scissors, win)
                    }
                }

                else // Scissors
                {
                    if (yourChoice == "X") // rock
                    {
                        totalScore += 7; // 1 + 6 (rock, win)
                    }
                    else if (yourChoice == "Y") // paper
                    {
                        totalScore += 2; // 2 + 0 (paper, loss)
                    }
                    else // scissors
                    {
                        totalScore += 6; // 3 + 3 (scissors, tie)
                    }
                }
            }
            Console.WriteLine("Part 1: " + totalScore);
        }

        static void Part2(string[] input)
        {
            // Rock = A, Paper = B, Scissors = C
            // X = lose, Y = draw, Z = win

            int totalScore = 0;

            for (int round = 0; round < input.Length; round++)
            {
                string[] parts = input[round].Split(' ');

                string oppChoice = parts[0];
                string outcome = parts[1];

                if (oppChoice == "A") // rock
                {
                    if (outcome == "X") // lose
                    {
                        totalScore += 3; // 3 + 0 (scissors, lose)
                    }
                    else if (outcome == "Y") // draw
                    {
                        totalScore += 4; // 1 + 3 (rock, draw)
                    }
                    else // win
                    {
                        totalScore += 8; // 2 + 6 (paper, win)
                    }
                }

                else if (oppChoice == "B") // paper
                {
                    if (outcome == "X") // loss
                    {
                        totalScore += 1; // 1 + 0 (rock, loss)
                    }
                    else if (outcome == "Y") // draw
                    {
                        totalScore += 5; // 2 + 3 (paper, draw)
                    }
                    else // win
                    {
                        totalScore += 9; // 3 + 6 (scissors, win)
                    }
                }

                else // scissors
                {
                    if (outcome == "X") // loss
                    {
                        totalScore += 2; // 2 + 0 (paper, loss)
                    }
                    else if (outcome == "Y") // draw
                    {
                        totalScore += 6; // 3 + 3 (scissors, draw)
                    }
                    else // win
                    {
                        totalScore += 7; // 1 + 6 (rock, win)
                    }
                }
            }
            Console.WriteLine("Part 2: " + totalScore);
        }
    }
}