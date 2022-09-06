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
        public void SelectStack(int selectedStack)
        {
            SelectedStack = selectedStack;
        }

        public void CountDisksOnTheStack()
        {

        }

        // properties
        public int SelectedStack { get; set; } // [1], [2], [3]
        public List<Disk> Disks { get; set; }
    }
}
