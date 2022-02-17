public int RemoveElement(int[] nums, int val) {
        if (nums == null || nums.Length == 0)
            return 0;
        
        // two pointers
        int i = 0, j = 0;
        
        while (i < nums.Length && j < nums.Length)
        {
            if (nums[j] != val)
            {
                nums[i] = nums[j];
                i++;
                j++;
            }
            else
            {
                j++;
            }
        }
        
        return i;
    }