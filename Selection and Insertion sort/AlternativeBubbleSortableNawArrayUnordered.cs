using System;
using Alg1.Practica.Practicum2;
namespace Alg1.Practica.Practicum3
{
    public class AlternativeBubbleSortableNawArrayUnordered : BubbleSortableNawArrayUnordered
    {
        public AlternativeBubbleSortableNawArrayUnordered(int size) : base(size)
        {
        }

        public void BubbleSortAlternative()
        {
            for(int i1 = Count - 1; i1 > 0; i1--)
            {
                for (int inner = 0; inner < i1; i1++)
                {
                    if (Array[inner].CompareTo(Array[inner + 1]) > 0)
                        Array.Swap(inner, inner + 1);
                }
            }
        }
    }
}
