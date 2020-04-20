using System;

namespace InsertionSort
{
    public static class Program
    {
       
        private static int[] InsertionSort(int[] array)
        {
            for (var index = 1; index < array.Length; index++)
            {
                var key = array[index];
                var indexOfSorted = index;
                while (indexOfSorted > 0 && array[indexOfSorted - 1] > key)
                {
                    Swap(ref array[indexOfSorted - 1], ref array[indexOfSorted]);
                    indexOfSorted--;
                }

                array[indexOfSorted] = key;
            }
            return array;
        }

        private static void Swap(ref int A, ref int B)
        {
            var temp = A;
            A = B;
            B = temp;
        }

        public static void Main(string[] args)
        {
            Console.Write("Please, enter the values: ");
            var values = Console.ReadLine()?.Split(new[] { " ", "," },
                                                            StringSplitOptions.RemoveEmptyEntries);
            var array = new int[values.Length];
            for (var index = 0; index < values.Length; index++)
                array[index] = Convert.ToInt32(values[index]);

            Console.WriteLine("Sorted by insertions: {0}", string.Join(" ", InsertionSort(array)));
        }
    }
}
