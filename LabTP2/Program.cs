using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP2
{
    public class CustomCollection<T> : IEnumerable<T>, IComparer<T>
    {
        private List<T> innerList;

        public CustomCollection()
        {
            innerList = new List<T>();
        }

        public void AddItem(T arg)
        {
            innerList.Add(arg);
        }

        public void RemoveAt(int num)
        {
            if (innerList.Count <= num)
            {
                throw new IndexOutOfRangeException("Данный индекс выходит за пределы списка!");
            }
            else
            {
                innerList.RemoveAt(num);
            }
        }

        public T ElementAt(int num)
        {
            if (innerList.Count <= num)
            {
                throw new IndexOutOfRangeException("Данный индекс выходит за пределы списка!");
            }
            else
            {
                return innerList.ElementAt(num);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        public int Compare(T x, T y)
        {
            if (y.GetHashCode() == x.GetHashCode())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomCollection<int> custom = new CustomCollection<int>();
            int n, t;

            Console.WriteLine();

            n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                custom.AddItem(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine();

            foreach (int element in custom)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

    }
}
