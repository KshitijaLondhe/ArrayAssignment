using System;
/*6.WAP to left rotate the array
ar ={ 1,2,3,4,5}
o / p: { 3,4,5,1,2}
*/
namespace ArrayAssignment
{
    public class LeftRotate
    {
        public static void LeftRotateArray(int[] a, int rotation)
        {
            int n = a.Length;
            for (int i = 0; i < rotation; i++)
            {
            int first = a[0];
            for (int j = 0; j < n - 1; j++)
            {
                a[j] = a[j + 1];
            }
            a[n - 1] = first;
        }

    }
   /* static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5 };
            // o/p = { 3,4,5,1,2}
            Console.WriteLine("array");
            foreach (int a1 in a)
            {
                Console.WriteLine(a1);
            }
            int rotation = 2;
        LeftRotateArray(a, rotation);
            Console.WriteLine("Array after left rotating");
            foreach (int a1 in a)
            {
                Console.WriteLine(a1);
            }

        }*/
}
}
