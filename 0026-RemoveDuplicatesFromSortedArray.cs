public int RemoveDuplicates(int[] nums) {
        int l = nums.Length;
        if (l == 0 || l == 1)
            return l;
        
        int j = 0;
        for (int i = 0; i < l-1; i++)
        {
            if (nums[i] != nums[i+1])
                nums[j++] = nums[i];
        }
        
        nums[j++] = nums[l-1];
        return j;
    }