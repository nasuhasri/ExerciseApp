using System;
using System.Collections.Generic;

namespace ExerciseApp
{
    public class Stack
    {
        // readonly - dont want to accidentally re-initialize the list anywhere else in the class
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Object cannot be null!");
            }

            Console.WriteLine("Push...");
            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("There is no object left in the list!");
            }

            Console.WriteLine("Pop...");

            // get the last item added in the stack
            var index = _list.Count - 1;

            var objToReturn = _list[index];

            _list.RemoveAt(index);

            return objToReturn;
        }

        public void Clear()
        {
            _list.Clear();
            Console.WriteLine("Clear...");
        }
    }
}
