class Program
    {
        public int SingleNumber(int[] nums)
        {
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++)
                res ^= nums[i];
            return res;
        }

        //static void Main(string[] args)
        //{
        //    int[] nums = { 2, 3, 5, 4, 5, 3, 4 };
        //    Console.WriteLine(SingleNumber(nums));
        //}
    }