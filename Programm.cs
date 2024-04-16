using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayG<int> intArray = new ArrayG<int>(3);
            intArray.Add(83);
            intArray.Add(37);
            intArray.Add(1);

            Console.WriteLine(intArray.Get());

            intArray.Remove(0);

            Console.WriteLine(intArray.Get());

            intArray.Remove(5);

            Console.WriteLine(intArray.Get(5));

            Console.WriteLine(intArray.Length());
        }
    }
    public class ArrayG<T>
    {
        private int size;
        private T[] array;

        public ArrayG(uint size)
        {
            array = new T[size];
            size = 0;
        }
        public void Add(T item)
        {
            if (size < array.Length)
            {
                array[size] = item;
                size++;
            }
            else
                Console.WriteLine("Массив переполнен!");
        }
        public void Remove(uint index)
        {
            if (index <= size)
            {
                array[index] = default(T);
            }
            else
                Console.WriteLine("Некорректный индекс!");
        }
        public T Get(uint index)
        {
            if (index <= size)
                return array[index];
            else
                return default(T);
        }
        public string Get()
        {
            string str = "";
            return str = string.Join(", ", array);
        }
        public int Length()
        {
            return size;
        }
    }
}
