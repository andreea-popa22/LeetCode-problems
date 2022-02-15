public int[] TwoSum(int[] nums, int target) {
        int l = nums.Length;
        Dictionary < int, int > hashTable = new();
        for (int i = 0; i < l; i++)
        {
            int dif = target-nums[i];
            if (hashTable.TryGetValue(dif, out int index))
            {
                return new int[] {index, i};
            }
            hashTable[nums[i]] = i;
        }
        return new int[] {-1, -1};
    }