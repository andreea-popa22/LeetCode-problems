public int[] PlusOne(int[] digits)
    {
        int l = digits.Length;
        digits[l - 1] += 1;
        int rem = 0;
        for (int i = l - 1; i >= 0; i--)
        {
            if (rem == 1)
            {
                digits[i]++;
                rem = 0;
            }
            if (digits[i] == 10)
            {
                digits[i] = 0;
                rem = 1;
            }
        }
        if (rem == 1)
        {
            digits = digits.Concat(new int[] { digits[l-1] }).ToArray();
            for (int i = l - 1; i > 0; i--)
                digits[i] = digits[i - 1];
            digits[0] = 1;
        }
        return digits;
    }