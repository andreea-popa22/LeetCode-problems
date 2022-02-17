public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1)
            return strs[0];
        
        string pref = "";
        
        if (strs.Length == 0)
            return pref;
        
        for (int i = 0; i < strs[0].Length; i++)
        {
            foreach (string word in strs)
            {
                if (i > word.Length-1 || word[i] != strs[0][i])
                    return pref;
            }
            pref += strs[0][i];
        }
        return pref;
    }