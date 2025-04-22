namespace SR1
{
    public static class Calculation
    {
        public static int CalculateSum(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 11 == 0 && i % 8 == 5)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static int SumOfCubesDivisibleBy7(int x1, int x2, int x3)
        {
            int[] numbers = { x1, x2, x3 };
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 7 == 0)
                {
                    sum += number * number * number;
                }
            }
            return sum;
        }
    }
}
