using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Models
{
    public class Disk
    {
        // constructors
        public Disk() { }

        public Disk(int diskSize)
        {
            DiskSize = diskSize;
        }
        
        // methods
        public override string ToString()
        {
            int hashSize = DiskSize / 2;
            int emptySpaceSize = 4 - hashSize;

            string text = "  ";

            text += string.Concat(Enumerable.Repeat(" ", emptySpaceSize)); // "  ##|##  "
            text += string.Concat(Enumerable.Repeat("#", hashSize));
            text += "|";
            text += string.Concat(Enumerable.Repeat("#", hashSize));
            text += string.Concat(Enumerable.Repeat(" ", emptySpaceSize));
            text += "  ";

            return text;
        }
        
        // properties
        public int DiskSize { get; } // disk size e.g. 2, 4, 6, 8
    }
}
