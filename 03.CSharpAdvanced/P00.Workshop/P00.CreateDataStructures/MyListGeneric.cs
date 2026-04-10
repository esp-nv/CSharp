using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P00.CreateDataStructures
{
    public class MyListGeneric<T> : IEnumerable<T>
    {
        private int capacity;
        private T[] data;

        private List<int> list;
        public MyListGeneric()
            : this(4)
        {
        }

        public MyListGeneric(int capacity)
        {
            this.capacity = capacity;
            this.data = new T[capacity];
        }


        public int Count { get; private set; }

        public void Add(T element)
        {
            this.CheckResizeNeeded();

            this.data[this.Count] = element;

            this.Count++;
        }

        public void Insert(int index, T element)
        {
            this.ValidateIndex(index);
            this.CheckResizeNeeded();

            for (int i = this.Count - 1; i >= index; i--)
            {
                this.data[i + 1] = this.data[i];
            }

            this.data[index] = element;
            this.Count++;
        }

        public T RemoveAt(int index)
        {

            this.ValidateIndex(index);

            var result = this.data[index];

            for (int i = index + 1; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }

            this.Count--;

            return result;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);

            var firstValue = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstValue;

        }

        //indeksator - proparti
        public T this[int index]
        {
            //kogato iskame da vzemem stijnost na daden index
            get
            {
                this.ValidateIndex(index);
                return this.data[index];
            }
            //kogato iskame da vzemem zapishem stojnost na daden index
            set
            {
                this.ValidateIndex(index);
                this.data[index] = value;
            }
        }

        public int RemoveAll(Func<T, bool> filter)
        {
            var removed = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (filter(this.data[i]))
                {
                    this.RemoveAt(i);
                    removed++;
                }
            }

            return removed;
        }

        public bool TrueForAll(Func<T, bool> predicate)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (!predicate(this.data[i]))
                {
                    return false;
                }
            }
            return true;
        }

        // iztriva celiq list
        public void Clear()
        {
            this.Count = 0;
            this.data = new T[this.capacity];
        }
        private void Resize()
        {
            var newCapacity = this.data.Length * 2;

            var newData = new T[newCapacity];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;

        }


        private void CheckResizeNeeded()
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
        }

        //proverka za validen index
        private void ValidateIndex(int index)
        {
            if (index >= 0 && index < Count)
            {
                return;
            }
            var message = this.Count == 0
                ? "The list is empty."
                : $"The list {this.Count} elements and it is zero besed.";
            if (index < 0 || index >= this.Count)
            {
                throw new Exception($"Index of range.{message}");
            }

        }

        public IEnumerator<T> GetEnumerator()
          => (IEnumerator<T>)this.data.Take(this.Count).GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
