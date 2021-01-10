using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    public class CustomList<T> : ICustomList<T>, IEnumerable<T>, IEnumerable where T : IComparable 
    {
        private T[] Data;
        public int Count { get; private set; }
        private int Capacity => Data.Length;
        public CustomList()
        {
            Data = new T[10];
            Count = 0;
        }

        private void Resize(int numberOfElements)
        {
            int desiredCapacity = this.Count + numberOfElements;
            if (this.Capacity < desiredCapacity)
            {
                var ourList = this.Data;
                this.Data = new T[desiredCapacity + 10];
                for (int i = 0; i < ourList.Length; i++)
                {
                    this.Data[i] = ourList[i];
                }
            }
        }

        public void Add(T item)
        {
            this.Resize(1);
            this.Data[Count] = item;
            this.Count++;
        }

        public void AddRange(ICollection<T> collection)
        {
            this.Resize(collection.Count);
            foreach (var item in collection)
            {
                this.Data[Count] = item;
                this.Count++;
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (item.CompareTo(this.Data[i]) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            this.Resize(1);
            for (int i = this.Count - 1; i >= index; i--)
            {
                this.Data[i + 1] = this.Data[i];
            }
            this.Data[index] = item;
            this.Count++;
        }

        public bool Remove(T item)
        {
            var index = this.IndexOf(item);
            if (index == -1)
            {
                return false;
            }
            this.RemoveAt(index); // dry
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                return;
            }
            for (int i = index + 1; i < this.Count; i++)
            {
                this.Data[i - 1] = this.Data[i];
                this.Data[i] = default;
            }
            this.Count--;
        }
        public void Print()
        {
            Console.WriteLine("Your custom list:");

            for (int i = 0; i < this.Count; i++)
            {
                Console.Write($"{this.Data[i]} ");
            }
            Console.Write("\n");

        }
        public void Sort()
        {
            for (int i = 0; i < this.Data.Length - 1; i++)
            {
                for (int j = i + 1; j < this.Data.Length; j++)
                {
                    if (this.Data[i].CompareTo(this.Data[j]) == 1)
                    {
                        T temp = this.Data[i];
                        this.Data[i] = this.Data[j];
                        this.Data[j] = temp;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in this.Data)
            {
                yield return t;                
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
