using Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Domain.Models
{
    public class Cordinate<T> : ICordinate
    {
        public Cordinate(T x, T y)
        {
            _x = x;
            _y = y;
        }
        public string GetCordinate()
        {
            return $"{_x} {_y}";
        }

        public void ResetCordinate()
        {
            T _x;
            T _y;
        }

        private T _x;
        private T _y;
    }
}
