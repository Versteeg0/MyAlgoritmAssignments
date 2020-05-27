using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;

namespace Alg1.Practica.Practicum2
{
    public class BubbleSortableNawArrayUnordered : NawArrayUnordered, IBubbleSort
    {
        public BubbleSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void BubbleSort()
        {
            int i1;
            int i2;

            for (i1 = _used - 1; i1 > 0; i1--)
            {
                for (i2 = 0; i2 < i1; i2++)
                {
                    if (_nawArray[i2].CompareTo(_nawArray[i2 + 1]) == 1)
                    {
                        _nawArray.Swap(i2, i2+1);
                    }
                }
            }

        }

        public void BubbleSortInverted()
        {
            int i1;
            int i2;

            for (i1 = 0; i1 < _used; i1++)
            {
                for (i2 = 1; i2 < _used - i1; i2++)
                {
                    if (_nawArray[i2 - 1].CompareTo(_nawArray[i2]) == 1)
                    {
                        _nawArray.Swap(i2 - 1, i2);
                    }
                }
            }
        }
    }
}
