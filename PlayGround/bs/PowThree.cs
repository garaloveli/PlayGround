using System;
namespace PlayGround.bs
{
    public class PowThree
    {
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var valPow = Math.Pow(11, N);
            string strPow = valPow.ToString();
            int countOnes = 0;

            for (int i = 0; i < strPow.Length; i++)
            {
                if (strPow[i] == '1') { countOnes++; }
            }
            Console.WriteLine(strPow);
            Console.WriteLine(valPow);
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
