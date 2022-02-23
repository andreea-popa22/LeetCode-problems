public int ClimbStairs(int n) {
        if (n <= 2)
            return n;
        int s1 = 1;
        int s2 = 2;
        for (int i = 3; i < n; i++)
        {
            int curr = s1+s2;
            s1 = s2;
            s2 = curr;
        }
        return s1+s2;
    }