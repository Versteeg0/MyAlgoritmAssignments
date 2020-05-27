using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
namespace Alg1.Practica.Practicum3
{
    public class SelectionSortableNawArrayUnordered : NawArrayUnordered, ISelectionSort
    {
        public SelectionSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void SelectionSort()
        {
            int outer;
            int inner;
            int min;

            for(outer = 0; outer < _used - 1; outer++)
            {
                min = outer;
                for (inner = outer + 1; inner < _used; inner++)
                {
                    if (_nawArray[inner].CompareTo(_nawArray[min]) == -1)
                    {
                        min = inner;
                    }
                }
                if (min != outer)
                {
                    _nawArray.Swap(outer, min);
                }
            }
        }

        public void SelectionSortInverted()
        {
            int outer;
            int inner;
            int min;

            for (outer = _used - 1; outer > 0; outer--)
            {
                min = outer;
                for (inner = outer - 1; inner > 0; inner--)
                {
                    if (Array[inner].CompareTo(Array[min]) == 1)
                    {
                        min = inner;
                    }
                }
                if (min != outer)
                {
                    _nawArray.Swap(outer, min);
                }
            }
        }
    }
}
