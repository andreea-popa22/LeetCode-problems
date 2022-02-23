public int LengthOfLastWord(string s) {
        int l = 0;
        bool started = false;
        for (int i = s.Length-1; i >= 0; i--)
        {
            if (!started && s[i] == ' ')
                continue;
            if (started && s[i] == ' ')
                break;
            if (started && s[i] != ' ')
                l++;
            if (!started && s[i] != ' ')
            {
                started = true;
                l++;
            }
        }
        return l;
    }