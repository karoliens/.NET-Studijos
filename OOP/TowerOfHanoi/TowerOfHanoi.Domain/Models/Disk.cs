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


        // properties
        public int DiskSize { get; set; } // disk size e.g. 2, 4, 6, 8
    }
}
