using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// A last in first out collection implemented as a lined list 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T> : IEnumerable<T>
    {
        private LinkedList<T> _List = new LinkedList<T>();
        public void Push(T item) {
            _List.AddFirst(item);
        }
        public T Pop()
        {
            if (_List.Count == 0) { throw new InvalidOperationException("The Stack is Empty"); }
            T value = _List.First.Value;
            _List.RemoveFirst();
            return value;
        }
        public T Peek()
        {
            if (_List.Count == 0) { throw new InvalidOperationException("The Stack is Empty"); }
            return _List.First.Value;            
        }
        public int Count
        {
            get
            {
                return _List.Count;
            }
        }
        public void Clear()
        {
            _List.Clear();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return _List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _List.GetEnumerator();
        }
    }
}
