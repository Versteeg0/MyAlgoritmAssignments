using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg1.Practica.Practicum1
{
    public class NawArrayUnordered : INawArray
    {
        protected Alg1NawArray _nawArray;
        public Alg1NawArray Array => _nawArray;
        protected int _size;
        protected int _used;
        public NawArrayUnordered(int initialSize)
        {
            if (initialSize <= 0 || initialSize > 1000000)
                throw new NawArrayUnorderedInvalidSizeException();
            _nawArray = new Alg1NawArray(initialSize);
            _size = initialSize;
            _used = 0;
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
                int i = _used;
                _nawArray[i] = item;
                _used++;
            }
            else throw new NawArrayUnorderedOutOfBoundsException();
        }

        public int Find(NAW item)
        {
            int k = -1;
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

        public void Show()
        {
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

        public NAW ItemAtIndex(int index)
        { 
            if (index < 0 || index > _used)
            {
                throw new NawArrayUnorderedOutOfBoundsException();
            }
            else return _nawArray[index];
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index > _used)
            {
                throw new NawArrayUnorderedOutOfBoundsException();
            }
            else
            {
                int i = index;
                if(i < _used -1)
                {
                    for(int j = i; j < _used; j++)
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

        public bool Remove(NAW item)
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
    }
}
