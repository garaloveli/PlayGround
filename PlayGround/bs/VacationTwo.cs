using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayGround.bs
{
    //[1, 2, 3, 4, 4, 3, 3, 5, 4, 3, 2, 1] 

    public class VacationTwo
    {

        public int distance(Dictionary<int, int> vacations, int day, int trip)
        {
            int res = 0;
            foreach (var vacation in vacations)
            {
                if (vacation.Key != trip)
                {
                    res += Math.Abs(vacation.Value - day);
                }
            }
            return res;
        }

        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Dictionary<int, int> myvacations = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!myvacations.ContainsKey(A[i]))
                {
                    myvacations.Add(A[i], i);
                }
            }

            List<Dictionary<int, int>> sequences = new List<Dictionary<int, int>>();

            Dictionary<int, int> pos = new Dictionary<int, int>();
            sequences.Add(pos);
            for (int i = 0; i < A.Length; i++)
            {
                if (pos.Count == myvacations.Count)
                {
                    pos = new Dictionary<int, int>();
                    sequences.Add(pos);
                }

                if (!pos.ContainsKey(A[i]))
                {
                    pos.Add(A[i], i);
                }
            }

            var min = int.MaxValue;

            foreach (var item in sequences.Where(c => c.Count == myvacations.Count))
            {
                var minint = item.Values.Min();
                var maxint = item.Values.Max();

                var nmin = (maxint - minint);
                if (nmin < min)
                    min = nmin;
            }
            return min;
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace demoApp
//{
//    class Program
//    {

//        public static int distance(Dictionary<int, int> vacations, int day, int trip)
//        {
//            int distance = 0;
//            foreach (var vacation in vacations)
//            {
//                if (vacation.Key != trip)
//                {
//                    distance += Math.Abs(vacation.Value - day);
//                }
//            }
//            return distance;
//        }

//        public static int solution(int[] A)
//        {
//            Dictionary<int, int> myvacations = new Dictionary<int, int>();
//            for (int i = 0; i < A.Length; i++)
//            {
//                if (!myvacations.ContainsKey(A[i]))
//                {
//                    myvacations.Add(A[i], i);
//                }
//                else
//                {
//                    int target_trip = A[i];
//                    int original_day = myvacations[target_trip];
//                    long sumOriginal = distance(myvacations, original_day, target_trip);
//                    long sumTarget = distance(myvacations, i, target_trip);

//                    if (sumTarget <= sumOriginal)
//                    {
//                        myvacations[target_trip] = i;
//                    }
//                }
//            }

//            var min = myvacations.Values.Min();
//            var max = myvacations.Values.Max();

//            foreach (var item in myvacations.OrderBy(c => c.Value))
//            {
//                Console.WriteLine(string.Format("{0} : {1}", item.Value, item.Key));
//            }

//            return (max - min) + 1;
//        }

//        static void Main(string[] args)
//        {
//            int[] A = new int[] { 7, 3, 7, 3, 1, 3, 4, 1 };
//            Console.WriteLine(solution(A));
//            //  7 3 7 3 1 3 4 1 2 
//            //  0 1 2 3 4 5 6 7 8

//[7, 3, 7, 3, 1, 3, 4, 1, 2]
//[0, 1, 2, 3, 4, 5, 6, 7, 8]



//            // 1 : 1 5 10 20
//            // 2 : 2 4 6 8
//            // 3 : 3 9 12


//        }
//    }
//}


public static int distance(Dictionary<int, int> vacations, int day, int trip)
{
    int distance = 0;
    foreach (var vacation in vacations)
    {
        if (vacation.Key != trip)
        {
            distance += Math.Abs(vacation.Value - day);
        }
    }
    return distance;
}

public static int solution(int[] A)
{
    Dictionary<int, int> myvacations = new Dictionary<int, int>();
    for (int i = 0; i < A.Length; i++)
    {
        if (!myvacations.ContainsKey(A[i]))
        {
            myvacations.Add(A[i], i);
        }
    }

    List<Dictionary<int, int>> sequences = new List<Dictionary<int, int>>();

    Dictionary<int, int> pos = new Dictionary<int, int>();
    sequences.Add(pos);
    for (int i = 0; i < A.Length; i++)
    {
        if (pos.Count == myvacations.Count)
        {
            pos = new Dictionary<int, int>();
            sequences.Add(pos);
        }

        if (!pos.ContainsKey(A[i]))
        {
            pos.Add(A[i], i);
        }
    }

    var min = int.MaxValue;

    foreach (var item in sequences)
    {
        var minint = item.Values.Min();
        var maxint = item.Values.Max();

        var nmin = (maxint - minint);
        if (nmin < min)
            min = nmin;
    }
    return min;
}