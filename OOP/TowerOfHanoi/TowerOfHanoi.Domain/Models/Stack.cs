using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Models
{
    public class Stack
    {
        // constructors
        public Stack() { }

        // methods
        public int CountDisks()
        {


            return;
        }

        public void RemoveDisk(Disk disk)
        {
            Disks.Remove(disk);
        }

        public void AddDisk(Disk disk)
        {
            Disks.Add(disk);
        }

        // properties
        public List<Disk> Disks { get; set; }
    }
}
