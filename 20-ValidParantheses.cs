    public char CorespPar(char c)
    {
        if (c == ')')
            return '(';
        if (c == ']')
            return '[';
        if (c == '}')
            return '{';
        return '-';
    }
    
    public bool IsValid(string s) {
        if (s == null || s.Length == 1)
            return false;
        string myStack = "";
        foreach (char c in s)
        {
            if ("{[(".Contains(c))
                myStack += c;
            else{
                if (myStack.Length == 0)
                {
                    return false;
                }
                if (CorespPar(c) == myStack[myStack.Length - 1])
                {
                    myStack = myStack.Remove(myStack.Length - 1);
                }
                else
                {
                    return false;
                }
            }
        }
        if (myStack.Length == 0)
            return true;
        return false;
    }