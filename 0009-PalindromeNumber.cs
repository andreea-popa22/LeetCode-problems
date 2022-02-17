public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }
        int rev = 0;
        int aux = x;
        while (aux != 0 )
        {
            rev = rev*10 + aux%10;
            aux /= 10;
        }
        if (x == rev)
        {
            return true;
        }
        return false;
    }