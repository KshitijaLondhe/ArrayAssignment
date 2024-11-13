using System;
//9. Shift even before odd 


namespace ArrayAssignment
{
    public class ShiftEven
    {
        public static void ShiftEvenBeforeOdd(int[] arr)
        {
            int index = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
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
    

    
       /* static void Main(string[] args)
        {
            
            int[] arr = { 1,8,5,3,4,9,7,6 };
            Console.WriteLine("Original Array:");
            PrintArray(arr);

             ShiftEvenBeforeOdd(arr);
            Console.WriteLine("Array after shifting even numbers before odd numbers:");
            PrintArray(arr);

            Console.ReadLine();
        }*/
    }
}
