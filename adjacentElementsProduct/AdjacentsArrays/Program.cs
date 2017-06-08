using System;

namespace AdjacentsArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] Array = { -23, 4, -3, 8, -12 };
            Console.WriteLine(arrayPset(Array));
        }


        public static int arrayPset(int[] inputArray) {

            int result = 0;

            for (int k = 1; k < inputArray.Length; k++) {

                if(inputArray[k] * inputArray[k-1] > result) {
                    result = inputArray[k] * inputArray[k + 1];
                }

            }


            return result;

        }
    }
}
