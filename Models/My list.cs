using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types__Collections.Models
{
    class MyList<T>
    {
        T[] arr;
        public int count { get => arr.Length; }
        public MyList()
        {
            arr = new T[0];

        }
       
        public T this[int index]
        {
            get
            {
                if (index < arr.Length)
                {
                    return arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < arr.Length)
                {
                    arr[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void Add(T num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
        }
        public void Clear()
        {
            arr = new T[0];
            object.Equals(count, 0);
        }

        public void Exist()
        {

        }
        public void Remove(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(arr[i],item))
                {
                    for (int j = i; j < arr.Length - i; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                }
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        public void Reverse()
        {

        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(arr[i], item))
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(arr[i], item))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

