using Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Domain.Models
{
    public class EntityRepository<T> where T : IUser, new()
    {
        private List<T> _nodes { get; set; }

        void Add(T node)
        {
            _nodes.Add(node);
        }

        void Remove(T node)
        {
            _nodes.Remove(node);
        }

        void Print()
        {
            foreach (var node in _nodes)
            {
                Console.WriteLine(node.ToString());
            }
        }

        List<T> Fetch(List<T> nodes)
        {
            return _nodes;
        }
    }
}
