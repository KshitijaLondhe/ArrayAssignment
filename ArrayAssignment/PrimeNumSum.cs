using System;
//1. Sum of prime number in array


namespace ArrayAssignment
{
    public class PrimeNumSum
    {
        public static bool Isprime(int num)
        {

            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int PrimeNumSum1(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)

            {
                if (Isprime(a[i]))
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }
        /*static void Main(string[] args)
        {
            
            int[] a = { 1, 2, 3, 4, 5 };
            foreach (int a1 in a)
            {
                Console.WriteLine(a1);
            }
            int result =PrimeNumSum1(a);
            Console.WriteLine($"Prime number sum is {result}");
        }*/
    }
}
