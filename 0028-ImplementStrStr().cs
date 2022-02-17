public int StrStr(string haystack, string needle) {
        if (needle.Length > haystack.Length)
            return -1;
        if (needle.Length == 0 || needle == haystack)
            return 0;
        
        int pos = -1;
        for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            bool ok = true;
            for (int j = 0; j < needle.Length; j++)
            {
                if (needle[j] != haystack[i+j])
                {
                    ok = false;
                    break;
                }
                
            }
            if (ok)
                return i;
        }
        return pos;
    }