using System;
namespace PlayGround.bs
{

    /*
  A[0] =  1
  A[1] =  4
  A[2] = -1
  A[3] =  3
  A[4] =  2
    */

    public class ArrayLengthOne
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int realSize = 0;
            int currentIndex = 0;
            int nextIndex = 0;

            if (A == null) return 0;

            int size = A.Length;
            if (size == 1)
            {
                return (A[0] == -1) ? 1 : 0;
            }

            for (int i = 0; i < size; i++)
            {
                nextIndex = A[currentIndex];
                if (nextIndex == -1)
                {
                    return realSize + 1;
                }
                else
                {
                    currentIndex = nextIndex;
                    realSize++;
                }
            }

            return 0;
        }
    }
}

/*
 * using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int realSize = 0;
        int currentIndex = 0;
        int nextIndex = 0;

        if (A == null) return 0;
        if (size < 0 || size > 200000) return 0;
        
        if (size == 1)
        {
            return (A[0] == -1) ? 1 : 0;
        }
        
        for (int i = 0; i < size; i++)
        {
            nextIndex = A[currentIndex];
            if (nextIndex == -1)
            {
                return realSize + 1;
            }
            else if (nextIndex > -1)
            {
                currentIndex = nextIndex;
                realSize++;
            }
        }

        return 0;        
    }
}
*/