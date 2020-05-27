using System;
using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;
namespace Alg1.Practica.Practicum3
{
    public class InsertionSortableNawArrayUnordered : NawArrayUnordered, IInsertionSort
    {
        public InsertionSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void InsertionSort()
        {
            int inner;
            int outer;

            for(outer = 1; outer < _used; outer++)
            {
                NAW temp = _nawArray[outer];
                inner = outer;

                while (inner > 0 && _nawArray[inner - 1].CompareTo(temp) == 1)
                {
                    _nawArray[inner] = _nawArray[inner - 1];
                    inner--;
                }
                if (inner != outer)
                {
                    _nawArray[inner] = temp;
                }
            }
        }

        public void InsertionSortInverted()
        {
            int inner;
            int outer;

            for (outer = _used - 2; outer > 0; outer--)
            {
                NAW temp = _nawArray[outer];
                inner = outer;

                while (inner < _used - 1 && _nawArray[inner + 1].CompareTo(temp) == -1)
                {
                    _nawArray[inner] = _nawArray[inner + 1];
                    inner++;
                }
                if (inner != outer)
                {
                    _nawArray[inner] = temp;
                }
            }
        }


    }
}
