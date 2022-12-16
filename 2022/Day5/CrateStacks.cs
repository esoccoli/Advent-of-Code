using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class CrateStacks
    {
        private int numStacks;
        private List<Stack<string>> stackDiagram;
        private List<string[]> instructions;

        public CrateStacks()
        {
            numStacks = 9;
            stackDiagram = new List<Stack<string>>();
            instructions = new List<string[]>();
        }

        /// <summary>
        /// Populates the list with each stack, and adds the appropriate crates to each stack
        /// </summary>
        /// <returns></returns>
        public List<Stack<string>> FillDiagram()
        {
            // Adds the proper number of stacks
            for (int i = 0; i < numStacks; i++)
            {
                stackDiagram.Add(new Stack<string>());
            }
            #region Adding crates to stacks
            // Hard coding bc lazy

            // Stack 1
            stackDiagram[0].Push("B");
            stackDiagram[0].Push("Q");
            stackDiagram[0].Push("C");

            // Stack 2
            stackDiagram[1].Push("R");
            stackDiagram[1].Push("Q");
            stackDiagram[1].Push("W");
            stackDiagram[1].Push("Z");

            // Stack 3
            stackDiagram[2].Push("B");
            stackDiagram[2].Push("M");
            stackDiagram[2].Push("R");
            stackDiagram[2].Push("L");
            stackDiagram[2].Push("V");

            // Stack 4
            stackDiagram[3].Push("C");
            stackDiagram[3].Push("Z");
            stackDiagram[3].Push("H");
            stackDiagram[3].Push("V");
            stackDiagram[3].Push("T");
            stackDiagram[3].Push("W");

            // Stack 5
            stackDiagram[4].Push("D");
            stackDiagram[4].Push("Z");
            stackDiagram[4].Push("H");
            stackDiagram[4].Push("B");
            stackDiagram[4].Push("N");
            stackDiagram[4].Push("V");
            stackDiagram[4].Push("G");

            // Stack 6
            stackDiagram[5].Push("H");
            stackDiagram[5].Push("N");
            stackDiagram[5].Push("P");
            stackDiagram[5].Push("C");
            stackDiagram[5].Push("J");
            stackDiagram[5].Push("F");
            stackDiagram[5].Push("V");
            stackDiagram[5].Push("Q");

            // Stack 7
            stackDiagram[6].Push("D");
            stackDiagram[6].Push("G");
            stackDiagram[6].Push("T");
            stackDiagram[6].Push("R");
            stackDiagram[6].Push("W");
            stackDiagram[6].Push("Z");
            stackDiagram[6].Push("S");

            // Stack 8
            stackDiagram[7].Push("C");
            stackDiagram[7].Push("G");
            stackDiagram[7].Push("M");
            stackDiagram[7].Push("N");
            stackDiagram[7].Push("B");
            stackDiagram[7].Push("W");
            stackDiagram[7].Push("Z");
            stackDiagram[7].Push("P");

            // Stack 9
            stackDiagram[8].Push("N");
            stackDiagram[8].Push("J");
            stackDiagram[8].Push("B");
            stackDiagram[8].Push("M");
            stackDiagram[8].Push("W");
            stackDiagram[8].Push("Q");
            stackDiagram[8].Push("F");
            stackDiagram[8].Push("P");
            #endregion

            return stackDiagram;
        }

        public List<string[]> FillInstructions(string[] input)
        {
            for (int i = 10; i < input.Length; i++)
            {
                string[] parts = input[i].Split(" ");

                // Index 0 = num to move
                // Index 1 = stack to take from
                // Index 2 = stack to move to
                instructions.Add(new string[] { parts[1], parts[3], parts[5] });
            }

            return instructions;
        }
    }
}