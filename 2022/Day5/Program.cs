namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../input.txt");

            CrateStacks diagram = new CrateStacks();

            List<Stack<string>> stacks = diagram.FillDiagram();
            List<string[]> instructions = diagram.FillInstructions(input);

            Part1(stacks, instructions);
            Part2(stacks, instructions);
        }

        static void Part1(List<Stack<string>> stacks, List<string[]> instructions)
        {
            string topOfStacks = "";
            for (int i = 0; i < instructions.Count; i++)
            {
                string strNumToMove = instructions[i][0];
                string strMoveFrom = instructions[i][1];
                string strMoveTo = instructions[i][2];

                int numToMove = Convert.ToInt32(strNumToMove);
                int moveFrom = Convert.ToInt32(strMoveFrom) - 1;
                int moveTo = Convert.ToInt32(strMoveTo) - 1;

                for (int crate = 0; crate < numToMove; crate++)
                {
                    string itemMoved = stacks[moveFrom].Pop();
                    stacks[moveTo].Push(itemMoved);
                }
            }

            for (int i = 0; i < stacks.Count; i++)
            {
                topOfStacks += stacks[i].Peek();
            }

            Console.WriteLine("Part 1: " + topOfStacks);
        }

        static void Part2(List<Stack<string>> stacks, List<string[]> instructions)
        {
            string topOfStacks = "";
            for (int i = 0; i < instructions.Count; i++)
            {
                string strNumToMove = instructions[i][0];
                string strMoveFrom = instructions[i][1];
                string strMoveTo = instructions[i][2];

                int numToMove = Convert.ToInt32(strNumToMove);
                int moveFrom = Convert.ToInt32(strMoveFrom) - 1;
                int moveTo = Convert.ToInt32(strMoveTo) - 1;

                List<string> cratesToMove = new List<string>();

                for (int crate = 0; crate < numToMove; crate++)
                {
                    if (stacks[moveFrom].Count != 0)
                    {
                        cratesToMove.Add(stacks[moveFrom].Pop());
                    }
                }
                
                cratesToMove.Reverse();

                for (int item = 0; item < cratesToMove.Count; item++)
                {
                    stacks[moveTo].Push(cratesToMove[item]);
                }
                cratesToMove.Clear();
            }
            for (int i = 0; i < stacks.Count; i++)
            {
                topOfStacks += stacks[i].Peek();
            }

            Console.WriteLine("Part 2: " + topOfStacks);
        }
    }
}