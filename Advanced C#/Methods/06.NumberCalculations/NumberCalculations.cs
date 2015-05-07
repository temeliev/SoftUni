using System;
//Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. 
//Overload the methods to work with numbers of type int and double.
class NumberCalculations
{
    static void Main()
    {
        double[] doubles = { 1.2, 3.2, 4.55, 10.22, 0.03 };
        int[] integers = { 1, 3, 4, 10, 1 };
        Console.WriteLine("Min -> double {0}  integer {1}", Min(doubles), Min(integers));
        Console.WriteLine("Max -> double {0}  integer {1}", Max(doubles), Max(integers));
        Console.WriteLine("Sum of elements -> double {0}  integer {1}", Sum(doubles), Sum(integers));
        Console.WriteLine("Products of elements -> double {0}  integer {1}", Product(doubles), Product(integers));
        Console.WriteLine("Avarage -> double {0}  integer {1}", Average(doubles), Average(integers));
    }

    public static double Min(double[] nums)
    {
        double min = double.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
            }
        }

        return min;
    }

    public static int Min(int[] nums)
    {
        int min = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (min >= nums[i])
            {
                min = nums[i];
            }
        }

        return min;
    }

    public static double Max(double[] nums)
    {
        double max = double.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (max <= nums[i])
            {
                max = nums[i];
            }
        }

        return max;
    }

    public static int Max(int[] nums)
    {
        int max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (max <= nums[i])
            {
                max = nums[i];
            }
        }

        return max;
    }

    public static double Average(double[] nums)
    {
        return Sum(nums) / nums.Length;
    }

    public static int Average(int[] nums)
    {
        return Sum(nums) / nums.Length;
    }

    public static double Sum(double[] nums)
    {
        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;
    }

    public static int Sum(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;
    }

    public static double Product(double[] nums)
    {
        double product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }

        return product;
    }

    public static int Product(int[] nums)
    {
        int product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }

        return product;
    }
}

