using System;

namespace AdjacentsArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] Array = { 1, -2, 4, 7, 6, 5, 9, 10 };
            Console.WriteLine(arrayPset(Array));
        }


        public static int arrayPset(int[] inputArray) {
            int result = 0;

            for (int k = 0; k < inputArray.Length; k++) {

                if(inputArray[k] * inputArray[k+1] > result) {
                    result = inputArray[k] * inputArray[k + 1];
                }

            }


            return result;

        }
    }
}
