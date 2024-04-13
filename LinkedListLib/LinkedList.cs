using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLib
{
    public class LinkedList
    {
        private double[] array;
        private int count;

        public Node Head { get; private set; }

        public void Add(double data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;

            count++;
        }

        public int CountElementsGreaterThanSeven()
        {
            if (Head == null)
                return 0;

            int count = 0;
            Node current = Head;

            while (true)
            {
                if (current.Data > 7)
                {
                    count++;
                }

                if (current.Next == null)
                    break;
                
                current = current.Next;
            }

            return count;
        }

        public double[] GetElements()
        {
            if (Head == null)
                return null;

            if (array != null)
                array = null;

            array = new double[count + 1];
            Node current = Head;
            int index = 0;

            while (true)
            {
                array[index] = current.Data;

                if (current.Next == null)
                    break;

                current = current.Next;
                index++;
            }

            return array;
        }

        public void Clear()
        {
            Head = null;
            count = 0;
        }
    }
}
