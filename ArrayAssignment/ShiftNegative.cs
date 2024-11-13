using System;
//10. Shift negative before positive in array


namespace ArrayAssignment
{
    public class ShiftNegative
    {
        public static void ShiftNegativeBeforePositive(int[] arr)
        {
            int index = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {

                    int temp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = temp;
                    index++;
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
        static void Main(string[] args)
        {
            

            int[] arr = { -1, 2, -3, 4, -5, 6, -7, 8, -9 };
            Console.WriteLine("Original Array:");
            PrintArray(arr);

            ShiftNegativeBeforePositive(arr);
            Console.WriteLine("Array after shifting negative numbers before positive numbers:");
            PrintArray(arr);

            Console.ReadLine();
            }
        }
}
