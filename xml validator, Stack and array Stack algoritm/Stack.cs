using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum5
{
    public class Stack : IStack
    {
        protected StackLink First { get; set; }

        public void Push(string value)
        {
            StackLink top = new StackLink();
            top.String = value;

            if (First == null)
            {
                top.Next = null;
            }
            else
            {
                top.Next = First;
            }
            First = top;
        }

        public string Pop()
        {
            if (First == null)
            {
                return null;
            }
            else
            {
                string temp = First.String;
                First = First.Next;
                return temp;
            }
        }

        public string Peek()
        {
            if (First == null)
            {
                return null;
            }
            else
            {
                return First.String;
            }
        }

        public bool IsEmpty()
        {
            if(First == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
