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
        public Disk(int diskSize, int diskLocation)
        {
            DiskSize = diskSize;
            DiskLocation = diskLocation;
        }

        // methods
        public void Move(int fromStack, int toStack)
        {
            Console.WriteLine($"Moving disk from stack {fromStack} to stack {toStack}");
        }

        public void GetDiskSize()
        {

        }

        // properties
        public int DiskSize { get; set; } // disk size e.g. 2, 4, 6, 8
        public int DiskLocation { get; set; } // disk location on the stack e.g. from top to bottom 1-4
    }
}
