using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;


namespace Alg1.Practica.Practicum1
{
    public class NawArrayOrdered : INawArray, INawArrayOrdered
    {
        protected Alg1NawArray _nawArray;

        public Alg1NawArray Array => _nawArray;

        protected int _size;
        protected int _used = 0;

        public NawArrayOrdered(int initialSize)
        {
            if (initialSize <= 0 || initialSize > 1000000)
                throw new NawArrayOrderedInvalidSizeException();
            _nawArray = new Alg1NawArray(initialSize);
            _size = initialSize;
            _used = 0;
        }

        public void Show()
        {
            // Niet gevraagd

            System.Console.WriteLine("Array contains {0} of {1} items.", _used, _size);
            for (int i = 0; i < _size; i++)
            {
                if (i == _used)
                {
                    System.Console.WriteLine("------------------------------------------------------");
                }
                System.Console.Write("Item {0} contains: ", i);
                if (_nawArray[i] != null)
                {
                    _nawArray[i].Show();
                }
                else
                {
                    System.Console.WriteLine("nothing");
                }
            }
        }

        public int Count
        {
            get { return ItemCount(); }
            set { _used = value; }

        }

        public int ItemCount()
        {
            return _used;
        }

        public virtual void Add(NAW item)
        {
            if (_used < _nawArray.Size)
            {
                int i;
                for (i = 0; i < _used; i++)
                {
                    if (_nawArray[i].CompareTo(item) == 1)
                    {
                        break;
                    }
                }
                for (int j = _used; j > i; j--)
                    _nawArray[j] = _nawArray[j - 1];
                _nawArray[i] = item;
                _used++;
            }
            else throw new NawArrayOrderedOutOfBoundsException();
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index > _used)
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }
            else
            {
                int i = index;
                if (i < _used - 1)
                {
                    for (int j = i; j < _used; j++)
                    {
                        _nawArray[j] = _nawArray[j + 1];
                    }
                }
                else
                {
                    _nawArray[index] = null;
                }
            }
            _used--;
        }

        public virtual bool Remove(NAW item)
        {
            int i;
            for (i = 0; i < _used; i++)
            {
                if (_nawArray.Equals(item))
                {
                    RemoveAtIndex(i);
                    return true;
                }
            }
            return false;
        }

        public NAW ItemAtIndex(int index)
        {
            if (index < 0 || index > _used)
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }
            else return _nawArray[index];
        }


        public int Find(NAW item)
        {
            int k = -1;
            if (_nawArray[0].CompareTo(item) == 1 || _nawArray[_used - 1].CompareTo(item) > _used -1)
            {
                return -1;
            }
            for (int i = 0; i < _used; i++)
            {
                if (_nawArray[i].Equals(item))
                {
                    k = i;
                    break;
                }
            }
            return k;
        }

        public bool Update(NAW oldValue, NAW newValue)
        {
            for (int i = 0; i < _used; i++)
            {
                if (_nawArray[i].Equals(oldValue))
                {
                    _nawArray[i] = newValue;
                    return true;
                }
            }
            return false;
        }
    }
}


