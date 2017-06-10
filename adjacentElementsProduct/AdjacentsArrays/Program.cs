using System;

namespace AdjacentsArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Adjacents Arrays PSet
            //Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
            int[] Array = { -23, 4, -3, 8, -12 };
            Console.WriteLine(arrayPset(Array));
            Console.ReadLine();
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
