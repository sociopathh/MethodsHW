using System;

namespace Task8AddNumbers
{
    class Task8AddNumbers
    {
        static void PrintNumber(int[] arr)
        {
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                Console.Write(arr[j]);
            }

            Console.WriteLine();
        }

        static void Main()
        {
            int[] a = { 1, 5, 9, 7, 9 };
            int[] b = { 8, 7, 4, 6 };
            Console.WriteLine(Add(a, b));
        }

        static int[] Add(int[] a, int[] b)
        {
            int[] sum = new int[(Math.Max(a.Length, b.Length) + 1)];
            int carry = 0;
            int i = 0;

            if (a.Length > b.Length)
            {
                return Add(b, a);
            }

            PrintNumber(a);
            PrintNumber(b);

            for (; i < a.Length; i++)
            {
                sum[i] = a[i] + b[i] + carry;
                carry = sum[i] / 10;
                sum[i] = sum[i] % 10;
            }

            for (; i < b.Length && carry != 0; i++)
            {
                sum[i] = b[i] + carry;
                sum[i] = sum[i] % 10;
            }

            for (; i < b.Length; i++)
            {
                sum[i] = b[i];
            }

            if (carry != 0)
            {
                sum[i] = 1;
            }
            else
            {
                Array.Resize(ref sum, sum.Length - 1);
            }

            return sum;
        }
    }
}