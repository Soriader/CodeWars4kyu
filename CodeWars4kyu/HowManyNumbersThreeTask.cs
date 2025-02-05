namespace CodeWars4kyu
{
    public class HowManyNumbersThreeTask
    {
        public static List<long> FindAll(int sumDigits, int numDigits)
        {
            List<long> result = new List<long>();
            GenerateNumbers(result, new List<int>(), sumDigits, numDigits, 1);
        
            if (result.Count == 0)
            {
                return new List<long>();
            }

            return new List<long> { result.Count, result.Min(), result.Max() };
        }

        private static void GenerateNumbers(List<long> result, List<int> currentNumber, int remainingSum, int remainingDigits, int startDigit)
        {
            if (remainingDigits == 0)
            {
                if (remainingSum == 0)
                {
                    long number = currentNumber.Aggregate(0L, (acc, digit) => acc * 10 + digit);
                    result.Add(number);
                }
                return;
            }

            for (int digit = startDigit; digit <= 9; digit++)
            {
                if (digit > remainingSum)
                {
                    break;
                }

                currentNumber.Add(digit);
                GenerateNumbers(result, currentNumber, remainingSum - digit, remainingDigits - 1, digit);
                currentNumber.RemoveAt(currentNumber.Count - 1);
            }
        }
    }
}
//https://www.codewars.com/kata/5877e7d568909e5ff90017e6/train/csharp