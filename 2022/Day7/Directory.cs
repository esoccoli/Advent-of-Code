using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Directory
    {
        private string name;
        private long size;
        private List<Item> filesContained;

        public string Name { get { return name; } set { name = value; } }
        public long Size { get { return size; } set { size += value; } }
        public List<Item> Children { get { return filesContained; } set { filesContained = value; } }
    }
}
