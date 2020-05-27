using Alg1.Practica.Utils;
using System;

namespace Alg1.Practica.Practicum5
{
    public class ArrayStack : IStack
    {
        protected string[] values;
        protected int size;
        protected int top;

        public ArrayStack(int capacity)
        {
            if(capacity <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            size = capacity;
            values = new String[size];
            top = - 1;
        }

        public void Push(string value)
        {
            if (!IsFull())
            {
                values[++top] = value;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                return null;
            }
            else
            {
                return values[top--];
            }
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
                return values[top];
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (top == size - 1);
        }
    }
}