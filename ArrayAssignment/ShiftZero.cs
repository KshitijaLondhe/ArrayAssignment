using System;
//8. Shift all zeros in the beginning of array/ Shift zeros at end


namespace ArrayAssignment
{
    public class ShiftZero
    {
        // Method to shift all zeros to the beginning of the array
        public static void ShiftZerosToBeginning(int[] arr)
        {
            int n = arr.Length;
            int j = n - 1;  // Index for the end of the array

            // Traverse the array from end to start
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] != 0)
                {
                    arr[j] = arr[i];
                    j--;
                }
            }

            // Fill the remaining positions with zeros
            while (j >= 0)
            {
                arr[j] = 0;
                j--;
            }
        }

            // Method to shift all zeros to the end of the array
            public static void ShiftZerosToEnd(int[] arr)
            {
                int n = arr.Length;
                int j = 0;  // Index for the start of the array

                // Traverse the array
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] != 0)
                    {
                        arr[j] = arr[i];
                        j++;
                    }
                }

                // Fill the remaining positions with zeros
                while (j < n)
                {
                    arr[j] = 0;
                    j++;
                }
            }

            // Method to print the array
            public static void PrintArray(int[] arr)
            {
                Console.WriteLine(string.Join(", ", arr));
            }

        /*static void Main(string[] args)
        {
            int[] array1 = { 1, 0, 2, 0, 3, 0, 4, 0 };
            int[] array2 = (int[])array1.Clone();

            Console.WriteLine("Original Array:");
            PrintArray(array1);

            ShiftZerosToBeginning(array1);
            Console.WriteLine("Array after shifting zeros to the beginning:");
            PrintArray(array1);

            ShiftZerosToEnd(array2);
            Console.WriteLine("Array after shifting zeros to the end:");
            PrintArray(array2);
        }*/



    }
}
