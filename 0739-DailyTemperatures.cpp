class Solution {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures) {
        stack<pair<int, int>> myStack;
        int n = temperatures.size();
        myStack.push({temperatures[n - 1], n - 1});
        
        vector<int> ans(n, 0);
        
        for (int i = n - 2; i >= 0; i--) {
            while(!myStack.empty() && temperatures[i] >= myStack.top().first) {
                myStack.pop();
            }
            
            ans[i] = myStack.empty() ? 0 : myStack.top().second - i;
            myStack.push({temperatures[i], i});
        }
        return ans;
    }
};