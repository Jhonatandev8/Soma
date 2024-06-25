public class Solution
{
    public static void Main(string[] args)
    {
        int[] nums = { 3,2,1,3 };
        int target = 6;
        int[] result = TwoSum(nums, target);
        Console.WriteLine($"Indices : {result[0]} e {result[1]}");
    }


    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {

            for (int j = i + 1; j < nums.Length; j++)
            {
                int soma = nums[i] + nums[j];
                if (soma == target)
                {
                    return new int[] { i, j };
                }

            }

        }
        throw new Exception("No two sum solution");



    }
}