namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../input.txt");


        }

        static void Part1(string[] input)
        {
            long sumDirSizes = 0;

            Stack<Directory> tree = new Stack<Directory>();
            
            foreach (string line in input)
            {
                if (line.StartsWith("$"))
                {
                    // is a command
                    if (line.Equals("$ ls"))
                    {
                        foreach (Directory dir in tree)
                        {
                            List<Item> children = dir.Children;

                            for (int i = 0; i < children.Count; i++)
                            {

                            }
                        }
                    }
                    else if (line.Equals("$ cd /"))
                    {
                        Directory rootDir = new Directory();
                        tree.Push(rootDir);
                    }
                    else if (line.Equals("$ cd .."))
                    {
                        tree.Pop();
                    }
                }
            }
        }
    }
}