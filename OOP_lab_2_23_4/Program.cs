using System;

namespace OOP_lab_2_23_4
{
    public class Program
    {
        public static int SumNegative(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element < 0)
                {
                    sum += element;
                }
            }

            return sum;
        }

        private static int IndexMin(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] <= array[index])
                {
                    index = i;
                }
            }

            return index;
        }

        private static int IndexMax(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] >= array[index])
                {
                    index = i;
                }
            }

            return index;
        }

        public static int Multiplication(int[] array)
        {
            int d = 1;

            int a = IndexMax(array);
            int b = IndexMin(array);

            bool zero = true;

            if (Math.Abs(a - b) > 1)
            {
                zero = false;
            }

            if (a > b)
            {
                for (int i = b + 1; i < a; ++i)
                {
                    d *= array[i];
                }
            }

            if (a < b)
            {
                for (int i = a + 1; i < b; ++i)
                {
                    d *= array[i];
                }
            }

            if (zero)
            {
                d = 0;
            }

            return d;
        }

        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            string[] elements = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int[] array = new int[n];

            int index = 0;

            foreach (string element in elements)
            {
                array[index] = int.Parse(element);

                ++index;

                if (index >= n)
                {
                    break;
                }
            }

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }

            Console.WriteLine("\nСума вiд'ємних елементiв масиву: {0}.\n", SumNegative(array));

            Console.WriteLine("Добуток елементiв масиву, розташованих мiж максимальним i мiнiмальним елементами: {0}.\n", Multiplication(array));

        }
    }
}
