using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Node<T>
    {
        public Node<T> Pointer { get; set; }
        public T Value { get; set; }
        public Node() 
        {
            Value = default;
            Pointer = null;
        }
    }
}
