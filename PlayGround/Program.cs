using System;


namespace PlayGround
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int[] a = new int[] {8, 4, 6, 2, 6, 4, 7, 9, 5, 8};
            //Console.WriteLine(FirstDuplicate(a));
            //Console.WriteLine("Hello World!");
            var gap = new BinaryGap();
            gap.solution(2);
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
