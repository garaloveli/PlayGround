﻿using System;
namespace PlayGround
{
    /*
A DNA sequence can be represented as a string consisting of the letters A, C, G and T, which correspond to the types of successive nucleotides in the sequence. Each nucleotide has an impact factor, which is an integer. Nucleotides of types A, C, G and T have impact factors of 1, 2, 3 and 4, respectively. You are going to answer several queries of the form: What is the minimal impact factor of nucleotides contained in a particular part of the given DNA sequence?

The DNA sequence is given as a non-empty string S = S[0]S[1]...S[N-1] consisting of N characters. There are M queries, which are given in non-empty arrays P and Q, each consisting of M integers. The K-th query (0 ≤ K < M) requires you to find the minimal impact factor of nucleotides contained in the DNA sequence between positions P[K] and Q[K] (inclusive).

For example, consider string S = CAGCCTA and arrays P, Q such that:

    P[0] = 2    Q[0] = 4
    P[1] = 5    Q[1] = 5
    P[2] = 0    Q[2] = 6
The answers to these M = 3 queries are as follows:

The part of the DNA between positions 2 and 4 contains nucleotides G and C (twice), whose impact factors are 3 and 2 respectively, so the answer is 2.
The part between positions 5 and 5 contains a single nucleotide T, whose impact factor is 4, so the answer is 4.
The part between positions 0 and 6 (the whole string) contains all nucleotides, in particular nucleotide A whose impact factor is 1, so the answer is 1.
Write a function:

class Solution { public int[] solution(string S, int[] P, int[] Q); }

that, given a non-empty zero-indexed string S consisting of N characters and two non-empty zero-indexed arrays P and Q consisting of M integers, returns an array consisting of M integers specifying the consecutive answers to all queries.

The sequence should be returned as:

a Results structure (in C), or
a vector of integers (in C++), or
a Results record (in Pascal), or
an array of integers (in any other programming language).
For example, given the string S = CAGCCTA and arrays P, Q such that:

    P[0] = 2    Q[0] = 4
    P[1] = 5    Q[1] = 5
    P[2] = 0    Q[2] = 6
the function should return the values [2, 4, 1], as explained above.

Assume that:

N is an integer within the range [1..100,000];
M is an integer within the range [1..50,000];
each element of arrays P, Q is an integer within the range [0..N − 1];
P[K] ≤ Q[K], where 0 ≤ K < M;
string S consists only of upper-case English letters A, C, G, T.
Complexity:

expected worst-case time complexity is O(N+M);
expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.
    */
    public class GenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //used jagged array to hold the prefix sums of each A, C and G genoms
            //we don't need to get prefix sums of T, you will see why.

            int sSize = S.Length;
            int genomSize = sSize + 1;
            int[][] genoms = new int[3][];
            genoms[0] = new int[genomSize];
            genoms[1] = new int[genomSize];
            genoms[2] = new int[genomSize];

            //if the char is found in the index i, then we set it to be 1 else they are 0
            //3 short values are needed for this reason
            short a, c, g;
            for (int i = 0; i < sSize; i++)
            {
                a = 0; c = 0; g = 0;
                if ('A' == (S[i]))
                {
                    a = 1;
                }
                if ('C' == (S[i]))
                {
                    c = 1;
                }
                if ('G' == (S[i]))
                {
                    g = 1;
                }
                //here we calculate prefix sums. To learn what's prefix sums look at here https://codility.com/media/train/3-PrefixSums.pdf

                genoms[0][i + 1] = genoms[0][i] + a;
                genoms[1][i + 1] = genoms[1][i] + c;
                genoms[2][i + 1] = genoms[2][i] + g;
            }

            int pSize = P.Length;
            int[] result = new int[pSize];
            //here we go through the provided P[] and Q[] arrays as intervals
            for (int i = 0; i < pSize; i++)
            {
                int fromIndex = P[i];
                //we need to add 1 to Q[i], 
                //because our genoms[0][0], genoms[1][0] and genoms[2][0]
                //have 0 values by default, look above genoms[0][i+1] = genoms[0][i] + a; 
                int toIndex = Q[i] + 1;
                if (genoms[0][toIndex] - genoms[0][fromIndex] > 0)
                {
                    result[i] = 1;
                }
                else if (genoms[1][toIndex] - genoms[1][fromIndex] > 0)
                {
                    result[i] = 2;
                }
                else if (genoms[2][toIndex] - genoms[2][fromIndex] > 0)
                {
                    result[i] = 3;
                }
                else
                {
                    result[i] = 4;
                }
            }

            return result;
        }
    }
}
