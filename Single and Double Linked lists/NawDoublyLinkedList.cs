using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum4
{
    public class NawDoublyLinkedList
    {
        public DoubleLink First { get; set; }
        public DoubleLink Last { get; set; }

        public void InsertHead(NAW naw)
        {
            DoubleLink link = new DoubleLink();
            link.Naw = naw;

            if (First == null)
            {
                First = link;
                Last = link;
            }

            else
            {
                link.Next = First;
                First.Previous = link;
                First = link;
            }
        }

        public NAW ItemAtIndex(int index)
        {
            return null;
        }

        public DoubleLink SwapLinkWithNext(DoubleLink link)
        {
            DoubleLink linknext = link.Next;
            DoubleLink next = linknext.Next;
            DoubleLink linkprevious = link.Previous;
            

            if (First == link)
            {
                First = linknext;
            }

            if (linkprevious != null)
            {
                linkprevious.Next = linknext;
            }
            linknext.Previous = linkprevious;
            linknext.Next = link;
            link.Previous = linknext;
            link.Next = next;
            if (next != null)
            {
                next.Previous = link;
            }
            if(Last == linknext)
            {
                Last = link;
            }
            return linknext;
    }

    public void BubbleSort()
    {
            int swapped;

            DoubleLink inner;
            DoubleLink outer = new DoubleLink();

        if (First == null)
            {
                return;
            }

            do
            {
                swapped = 0;
                inner = First;

                while (inner.Next != outer && inner.Next != null)
                {
                    if (inner.Naw.CompareTo(inner.Next.Naw) > 0)
                    {
                        NAW n = inner.Naw;
                        inner.Naw = inner.Next.Naw;
                        inner.Next.Naw = n;
                        swapped = 1;
                    }
                    inner = inner.Next;
                }
                outer = inner;
            }
            while (swapped != 0);
    }

    public BigO OrderOfBubbleSort()
    {
        return BigO.N2;
    }
}
}


