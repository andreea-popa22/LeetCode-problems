public int SearchInsert(int[] nums, int target) {
        if (nums == null || nums.Length == 0)
            return -1;
        
        int left = 0, right = nums.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right-left) / 2;
            
            if (target == nums[mid])
                return mid;
            
            if (nums[mid] < target)
                left = mid + 1;
            
            if (nums[mid] > target)
                right = mid - 1;
        }
        
        return left;
    }