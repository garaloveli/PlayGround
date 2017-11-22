using System;
namespace PlayGround
{
    public class MissingInteger
    {
        /*
Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Assume that:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.
        */

        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] res = new int[1000000];
            foreach (int val in A)
            {
                if (val > 0)
                {
                    res[val - 1] = val;
                }
            }

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == 0) return i + 1;
            }

            return 1;
        }

    }
}
