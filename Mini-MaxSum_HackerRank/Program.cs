using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_MaxSum_HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 254961783, 604179258, 462517083, 967304281, 860273491 };
            miniMaxSum(list);
        }

        public static void miniMaxSum(List<int> arr)
        {
            long sumf = 0;
            int suml = 0;
            long min = long.MaxValue;
            long max = long.MinValue;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        sumf += arr[j];
                    }
                }
                if (min > sumf)
                {
                    min = sumf;
                }
                if (max < sumf)
                {
                    max = sumf;
                }
                sumf = 0;
            }

            Console.WriteLine($"{min} {max}");
            
        }
    }
}
