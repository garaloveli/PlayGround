using System;
namespace PlayGround.bs
{
    public class PowThree
    {
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            BigInteger eleven = new BigInteger(11);
            BigInteger valPow = eleven;
            for (int i = 0; i < N; i++)
            {
                valPow = valPow * eleven;
            }

            string strPow = valPow.ToString();
            int countOnes = 0;

            for (int i = 0; i < strPow.Length; i++)
            {
                if (strPow[i] == '1') { countOnes++; }
            }

            return countOnes;


            ////return (int)valPow;
            //if (N == 0) return 1;

            //int nLength = Convert.ToString(N).Length;
            //int carry = 0;

            //int countOnes = 0;

            //for (int i = 0; i <= nLength; i++)
            //{
            //    int digit = carry;
            //    if (i < nLength){
            //        digit += 
            //    }

            //}



            //size_t len = strlen(num);
            //char* result = (char*)malloc(len + 3);
            //int carry = 0;
            //int num_ones = 0;
            //size_t i;

            //for (i = 0; i <= len; ++i)
            //{
            //    int digit = carry;

            //    if (i < len)
            //    {
            //        digit += num[i] - '0';
            //    }
            //    if (i > 0)
            //    {
            //        digit += num[i - 1] - '0';
            //    }

            //    if (digit < 10)
            //    {
            //        carry = 0;
            //    }
            //    else
            //    {
            //        digit -= 10;
            //        carry = 1;
            //    }

            //    if (digit == 1)
            //    {
            //        ++num_ones;
            //    }
            //    result[i] = digit + '0';
            //}

            //if (carry)
            //{
            //    result[i++] = '1';
            //    ++num_ones;
            //}

            //result[i] = '\0';

            //*num_ones_ptr = num_ones;
            //return result;

        }
    }
}


/*
 using System;
using System.Numerics;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (N < 0 || N > 1000) return 0; 
        if (N == 0) return 1;
        
        BigInteger eleven = new BigInteger(11);
        BigInteger valPow = eleven;
        for (int i = 0; i < N; i++)
        {
            valPow = valPow * eleven;
        }
        
        string strPow = valPow.ToString();
        int countOnes = 0;

        for (int i = 0; i < strPow.Length; i++)
        {
            if (strPow[i] == '1') { countOnes++; }
        }
        
        return countOnes;
    }
}
 */