using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;
using Alg1.Practica.Practicum1;


namespace Alg1.Practica.Practicum2
{
    public class BinarySearchableNawArrayOrdered : NawArrayOrdered, IBinarySearch
    {
        public BinarySearchableNawArrayOrdered(int initialSize) : base(initialSize)
        {
        }

        public int FindBinary(NAW item)
        {
            int lowerBound = 0;
            int upperBound = _used - 1;
            int curI;
            if (_used == 0)
            {
                return -1;
            }
            else
            {
                while (true)
                {
                    curI = (lowerBound + upperBound) / 2;
                    if (_nawArray[curI].CompareTo(item) == 0)
                    {
                        return curI;
                    }
                    else if (lowerBound > upperBound)
                    {
                        return _used;
                    }
                    else
                    {
                        if (_nawArray[curI].CompareTo(item) == -1)
                        {
                            lowerBound = curI + 1;
                        }
                        else
                        {
                            upperBound = curI - 1;
                        }
                    }
                }
            }
        }

        public void AddBinary(NAW item)
        {
            if (_used < _nawArray.Size)
            {
                int lowerBound = 0;
                int upperBound = _used - 1;
                int curI;

                if (_nawArray[lowerBound].CompareTo(item) == 1)
                {
                    curI = 0;
                }
                else if (_nawArray[upperBound].CompareTo(item) == -1)
                {
                    curI = _used;
                }
                else
                {
                    while (true)
                    {
                        curI = (lowerBound + upperBound) / 2;


                        if (_nawArray[curI].CompareTo(item) == 1 && _nawArray[curI - 1].CompareTo(item) == -1)
                            break;
                        else if (_nawArray[curI].CompareTo(item) == -1)
                        {
                            lowerBound = curI + 1;
                        }
                        else
                        {
                            upperBound = curI - 1;
                        }
                    }
                }
                    for (int i = _used; i > curI; i--)
                        _nawArray[i] = _nawArray[i - 1];
                    _nawArray[curI] = item;
                    _used++;
                
            }
            else
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }
        }
    }
}
    

