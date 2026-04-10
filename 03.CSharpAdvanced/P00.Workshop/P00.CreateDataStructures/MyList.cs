
using System;
using System.Collections.Generic;

namespace P00.CreateDataStructures
{
    public class MyList
    {
        private int capacity;
        private int[] data;

        private List<int> list;
        public MyList()
            : this(4)
        {
        }

        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
        }


        public int Count { get; private set; }

        //indeksator - proparti
        public int this[int index]
        {
            //kogato iskame da vzemem stijnost na daden index
            get
            {
                ValidateIndex(index);
                return this.data[index];
            }
            //kogato iskame da vzemem zapishem stojnost na daden index
            set
            {
                ValidateIndex(index);
                this.data[index] = value;
            }
        }

        public void Add(int element)
        {
            this.CheckResizeNeeded();

            this.data[this.Count] = element;

            this.Count++;
        }

        public void Insert(int index, int element)
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

        public int RemoveAt(int index)
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

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i] == element)
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

       

        // iztriva celiq list
        public void Clear()
        {
            this.Count = 0;
            this.data = new int[this.capacity];
        }

        private void Resize()
        {
            var newCapacity = this.data.Length * 2;

            var newData = new int[newCapacity];

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



        //proverka za voliden index
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

    }
}
