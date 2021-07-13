using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Stack.Model
{
    public class ArrayStack<T>
    {
        T[] items;

       
        private int current = -1;
        private readonly int size;

        public int MaxCount => items.Length;

        public int Count => current + 1;

        public ArrayStack(int size = 10) 
        {
            this.size = size;
            items = new T[size];
        }
        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current = 1;
        }
        public void Push(T data) 
        {
            if (current < size - 1)
            {
                current++;
                items[current] = data;
            }
            else 
            {
                throw new StackOverflowException("Stack is overflowed");
            }
        }
        public T Pop() 
        {
            if (current >= 0)
            {
                var item = items[current];
                current--;
                return item;
            }
            else 
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
        public T Peek() 
        {
            if (current >= 0)
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
    }
}
