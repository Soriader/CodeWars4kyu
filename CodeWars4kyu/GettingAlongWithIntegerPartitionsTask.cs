using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars4kyu
{
    public class GettingAlongWithIntegerPartitionsTask
    {
        public static string Part(long n)
        {
            List<List<long>> partitions = new List<List<long>>();
            GeneratePartitions(n, n, new List<long>(), partitions);

            List<long> products = partitions
                .Select(partition => MultiplicationMethod(partition.ToArray()))
                .Distinct() 
                .ToList();

            long range = products.Max() - products.Min();
            double average = products.Average();
            double median = GetMedian(products);

            return string.Format(CultureInfo.InvariantCulture, "Range: {0} Average: {1:F2} Median: {2:F2}", range, average, median);
        }

        private static double GetMedian(List<long> numbers)
        {
            numbers.Sort();
            int count = numbers.Count;
            if (count % 2 == 0)
            {
                return (numbers[count / 2 - 1] + numbers[count / 2]) / 2.0;
            }
            return numbers[count / 2];
        }


        private static void GeneratePartitions(long n, long max, List<long> current, List<List<long>> result)
        {
            if (n == 0)
            {
                result.Add(new List<long>(current));
                return;
            }

            for (long i = Math.Min(max, n); i >= 1; i--)
            {
                current.Add(i);
                GeneratePartitions(n - i, i, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }

        private static long MultiplicationMethod(long[] numbers)
        {
            long result = 0;
            result = numbers.Aggregate(1L, (acc, x) => acc * x);

            return result;
        }
    }
}
//https://www.codewars.com/kata/55cf3b567fc0e02b0b00000b/train/csharp