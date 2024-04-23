using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class PriorityQueue<T>
    {
        private List<T> data;
        private IComparer<T> comparer;

        public PriorityQueue()
        {
            data = new List<T>();
            comparer = Comparer<T>.Default;
        }

        public PriorityQueue(IComparer<T> comparer)
        {
            data = new List<T>();
            this.comparer = comparer;
        }

        public int Count => data.Count;

        public void Enqueue(T item)
        {
            data.Add(item);
            int childIndex = data.Count - 1;
            while (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (comparer.Compare(data[childIndex], data[parentIndex]) >= 0)
                    break;

                Swap(childIndex, parentIndex);
                childIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            if (data.Count == 0)
                throw new InvalidOperationException("Priority queue is empty.");

            int lastIndex = data.Count - 1;
            T frontItem = data[0];
            data[0] = data[lastIndex];
            data.RemoveAt(lastIndex);

            lastIndex--;
            int parentIndex = 0;

            while (true)
            {
                int childIndex = parentIndex * 2 + 1;
                if (childIndex > lastIndex)
                    break;

                int rightChildIndex = childIndex + 1;
                if (rightChildIndex <= lastIndex && comparer.Compare(data[rightChildIndex], data[childIndex]) < 0)
                    childIndex = rightChildIndex;

                if (comparer.Compare(data[parentIndex], data[childIndex]) <= 0)
                    break;

                Swap(parentIndex, childIndex);
                parentIndex = childIndex;
            }

            return frontItem;
        }

        public T Peek()
        {
            if (data.Count == 0)
                throw new InvalidOperationException("Priority queue is empty.");

            return data[0];
        }

        private void Swap(int i, int j)
        {
            T temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}
