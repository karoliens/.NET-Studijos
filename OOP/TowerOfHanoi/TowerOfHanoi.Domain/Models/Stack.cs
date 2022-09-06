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
        public Stack(int selectedStack)
        {
            SelectedStack = selectedStack;
        }

        // methods
        public void SelectStack(int selection)
        {
            SelectedStack = selectedStack;
        }

        public void CountDisksOnTheStack()
        {

        }

        // properties
        public Disk FirstStack { get; set; } // [1]
        public Disk SecondStack { get; set; } // [2]
        public Disk ThirdStack { get; set; } // [3]
        public List<Disk> Disks { get; set; }
    }
}
