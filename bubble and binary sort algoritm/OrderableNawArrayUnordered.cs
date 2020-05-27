using System;
using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;

namespace Alg1.Practica.Practicum2
{
    public class OrderableNawArrayUnordered : NawArrayUnordered, IToNawArrayOrdered
    {
        public OrderableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public INawArrayOrdered ToNawArrayOrdered()
        {
            NawArrayOrdered array = new NawArrayOrdered(_size); 
            for(int i = 0; i < _used; i++)
            {
                array.Add(_nawArray[i]);
            }
            return array;
        }
    }
}
