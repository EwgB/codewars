using System;
using System.Linq;

namespace TransformToPrime {
    /**
     * Given a List [] of n integers , finds minimum mumber to be inserted in a list
     * so that the sum of all elements of list should equal the closest prime number .
    */
    public class Solution {
        public static int MinimumNumber(int[] numbers) {
            var sum = numbers.Sum();

            var result = 0;
            while (!IsPrime(sum + result)) {
                result++;
            }

            return result;
        }

        private static bool IsPrime(int num) {
            foreach (var i in Enumerable.Range(2, (int)Math.Floor(Math.Sqrt(num)) - 1)) {
                if (num % i == 0) {
                    return false;
                }
            }

            return true;
        }
    }
}
