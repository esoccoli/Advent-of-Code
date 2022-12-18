using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Item
    {
        private string name;
        private long size;
        private Directory parentDir;

        public string Name { get { return name; } set { name = value; } }
        public long Size { get { return size; } set { size = value; } }
        public Directory Parent { get { return parentDir; } set { parentDir = value; } }
    }
}
