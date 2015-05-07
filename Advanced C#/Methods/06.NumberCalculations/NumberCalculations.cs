using System;
//Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. 
//Overload the methods to work with numbers of type decimal and double.
class NumberCalculations
{
    static void Main()
    {
        double[] doubles = { 1.2, 3.2, 4.55, 10.22, 0.03 };
        decimal[] decimals = { 1, 3, 4, 10, 1 };
        Console.WriteLine("Min -> double {0}  decimal {1}", Min(doubles), Min(decimals));
        Console.WriteLine("Max -> double {0}  decimal {1}", Max(doubles), Max(decimals));
        Console.WriteLine("Sum of elements -> double {0}  decimal {1}", Sum(doubles), Sum(decimals));
        Console.WriteLine("Products of elements -> double {0}  decimal {1}", Product(doubles), Product(decimals));
        Console.WriteLine("Avarage -> double {0}  decimal {1}", Average(doubles), Average(decimals));
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

    public static decimal Min(decimal[] nums)
    {
        decimal min = decimal.MaxValue;
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

    public static decimal Max(decimal[] nums)
    {
        decimal max = decimal.MinValue;
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

    public static decimal Average(decimal[] nums)
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

    public static decimal Sum(decimal[] nums)
    {
        decimal sum = 0;
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

    public static decimal Product(decimal[] nums)
    {
        decimal product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }

        return product;
    }
}

