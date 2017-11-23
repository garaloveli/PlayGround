using System;
using PlayGround.bs;

namespace PlayGround
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(FirstDuplicate(a));
            //Console.WriteLine("Hello World!");

            //int[] a = new int[] { 1, 4, -1, 3, 2 };
            //var gap = new ArrayLength();
            //var res = gap.solution(a);
            //Console.WriteLine(res);

            var res = new PowThree();

            for (int i = 0; i <= 1000; ++i)
            {
                Console.WriteLine("#de ceros: {0}", res.solution(i));
            }

            Console.ReadLine();
        }

        public static int FirstDuplicate(int[] a)
        {
            //int[] b = new int[a.Length];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    int pos = Array.IndexOf(b, a[i]);
            //    if (pos > -1) { return a[i]; }
            //    b[i] = a[i];
            //}
            //return -1;


            var dict = new System.Collections.Generic.Dictionary<int, int>();
            foreach (var aVal in a)
            {
                if (dict.ContainsKey(aVal))
                    return aVal;
                else
                    dict[aVal] = 1;
            }
            return -1;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[Math.Abs(a[i]) - 1] >= 0)
            //        a[Math.Abs(a[i]) - 1] = -a[Math.Abs(a[i]) - 1];
            //    else
            //        return Math.Abs(a[i]);
            //}
            //return -1;
        } 
    }
}
