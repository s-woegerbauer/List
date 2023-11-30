using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class OwnList<T>
    {
        public Node<T> Start { get; set; }
        public int Count { get; set; }

        public T this[int index] 
        {
            get
            {
                int count = 0;
                Node<T> currentNode = Start.Pointer;

                do
                {
                    currentNode = currentNode.Pointer;
                    count++;
                }
                while (count < Count + 1 && count != index + 1);

                return currentNode.Value;
            }
        }
        
        public OwnList()
        {
            Start = new Node<T>();
            Count = 0;
        }

        public void Add(T item)
        {
            int count = 0;
            Node<T> currentNode = Start;

            do
            {
                if (currentNode != null && currentNode.Pointer != null)
                {
                    currentNode = currentNode.Pointer;
                }

                count++;
            }
            while (count < Count);

            Count++;
            
            currentNode.Pointer = new Node<T>();
            currentNode.Pointer.Value = item;
        }
    }
}
