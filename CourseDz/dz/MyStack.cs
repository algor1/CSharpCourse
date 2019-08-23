using System;
using System.Collections.Generic;
using System.Text;

namespace dz
{
    public class MyStack<T>
    {
        private T[] items;
        private int counter;

        public MyStack()
        {
            const int DefaultCount = 4;
            items = new T[DefaultCount];
            counter = -1;
        }

        public void Push(T item)
        {
            if (counter == items.Length-1)
            {
                T[] newBiggerArray = new T[items.Length * 2];
                items.CopyTo(newBiggerArray, 0);
                items = newBiggerArray;
            }
            items[++counter] = item;
        }
        public T Pop()
        {
            if (counter < 0)
            {
                throw new ArgumentOutOfRangeException("Stack is empty, nothing to pop");
            }
            T retvalue = items[counter];
            items[counter--] = default(T);
            return retvalue;
        }
        public T Peek()
        {
            if (counter < 0)
            {
                throw new ArgumentOutOfRangeException("Stack is empty, nothing to peek");
            }
            return items[counter];
        }
    }
}
