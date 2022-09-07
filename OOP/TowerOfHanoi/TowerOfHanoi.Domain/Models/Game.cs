using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Models
{
    public class Game
    {
        public Stack FirstStack { get; set; } = new Stack();
        public Stack SecondStack { get; set; } = new Stack();
        public Stack ThirdStack { get; set; } = new Stack();   
    }
}
