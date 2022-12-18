using System.Data;
using System.Net.Http.Headers;

namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../input.txt");

            int[,] treeGrid = new int[input[0].Length, input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    treeGrid[i, j] = input[i][j];
                }
            }

            Part1(input, treeGrid);
            Part2(input, treeGrid);
        }

        static void Part1(string[] input, int[,] treeGrid)
        {
            int numVisFromEdge = 0;

            bool visLeft = true;
            bool visRight = true;
            bool visTop = true;
            bool visBottom = true;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (i == 0 || j == 0 || (i == input.Length - 1) || (j == input[i].Length - 1))
                    {
                        numVisFromEdge++;

                    }
                    else
                    {
                        // Check if vis from left
                        for (int row = i; row >= 0; row--)
                        {
                            if (treeGrid[i, j] <= treeGrid[row, j] && row != i)
                            {
                                visLeft = false;
                                break;
                            }
                        }

                        // Check if vis from right
                        for (int row = i; row < input.Length; row++)
                        {
                            if (treeGrid[i, j] <= treeGrid[row, j] && row != i)
                            {
                                visRight = false;
                                break;
                            }
                        }

                        // Check if vis from top
                        for (int col = j; col >= 0; col--)
                        {
                            if (treeGrid[i, j] <= treeGrid[i, col] && col != j)
                            {
                                visTop = false;
                                break;
                            }
                        }

                        // Check if vis from bottom
                        for (int col = j; col < input[i].Length; col++)
                        {
                            if (treeGrid[i, j] <= treeGrid[i, col] && col != j)
                            {
                                visBottom = false;
                                break;
                            }
                        }

                        if (visTop == true || visBottom == true || visLeft == true || visRight == true)
                        {
                            numVisFromEdge++;
                        }
                    }
                    
                    // lol need to reset these after each tree is checked, whoops
                    visLeft = true;
                    visRight = true;
                    visTop = true;
                    visBottom = true;
                }
            }

            Console.WriteLine("Part 1: " + numVisFromEdge);
        }

        static void Part2(string[] input, int[,] treeGrid)
        {
            int maxScenicScore = 1;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    int viewDistLeft = 1;
                    int viewDistRight = 1;
                    int viewDistTop = 1;
                    int viewDistBottom = 1;

                    // Check view dist to left
                    for (int row = i - 1; row >= 0; row--)
                    {
                        if (treeGrid[row, j] >= treeGrid[i, j])
                        {
                            viewDistLeft += (i - row) ;
                            break;
                        }
                    }

                    // Check view dist to right
                    for (int row = i + 1; row < input.Length; row++)
                    {
                        if (treeGrid[row, j] >= treeGrid[i, j])
                        {
                            viewDistRight += row - i;
                            break;
                        }
                    }

                    // Check view dist to top
                    for (int col = j - 1; col >= 0; col--)
                    {
                        if (treeGrid[i, col] >= treeGrid[i, j])
                        {
                            viewDistTop += j - col;
                            break;
                        }
                    }

                    // Check view dist to bottom
                    for (int col = j + 1; col < input[i].Length; col++)
                    {   
                        if (treeGrid[i, col] >= treeGrid[i, j])
                        {
                            viewDistBottom += (col - j);
                            break;
                        }
                    }

                    int currScore = (viewDistLeft * viewDistRight * viewDistTop * viewDistBottom);
                    
                    if (currScore > maxScenicScore)
                    {
                        maxScenicScore += currScore;
                    }
                }
            }
            
            Console.WriteLine("Part 2: " + maxScenicScore);
        }
    }
}