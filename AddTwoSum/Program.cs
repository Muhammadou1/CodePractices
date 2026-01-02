namespace AddTwoSum
{
    internal class Program
    {
        /**
         * Given an array of integers nums and an integer target,
         * return indices of the two numbers such that they add up to target.
         */
        static void Main(string[] args)
        {
            int[] nums = { 2, 8, 4 };
            int target = 10;

            AddTwoSum(nums, target);
            Console.WriteLine($"{nums[0]} + {nums[1]} = {target}");
            Console.WriteLine(string.Join(", ", $"{nums[0] + nums[1] == target}"));


        }


        public static int[] AddTwoSum(int[] nums, int target)
        {

            // have two numbers array that add to the target
            // nested loop to go iterate through every value pair
            // check to see if any value pair == to target

            // first iteration with i from index 0 to end n-1
            // second iteraion with j from index i + 1 to end n-1 to find to look for possible values of num[i]
            // check if i array + j array = target 
            //return

            Console.WriteLine();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }
            Console.WriteLine();

            return nums;

        }
    }
}
