using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Models
{
    public class Game
    {
        public Stack<int> FirstStack { get; set; }
        public Stack<int> SecondStack { get; set; }
        public Stack<int> ThirdStack { get; set; }
    }
}
