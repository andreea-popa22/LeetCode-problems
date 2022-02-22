public int TitleToNumber(string columnTitle) {
        if (columnTitle == null || columnTitle == string.Empty)
            return 0;
        
        var res = 0;
        var l = columnTitle.Length - 1;
        for(int i = l; i >= 0; i--)
        {
            res += (columnTitle[i] - 64) * (int)Math.Pow(26, l - i);
        }
        return res;
    }