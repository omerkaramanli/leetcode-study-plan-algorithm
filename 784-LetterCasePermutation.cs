public class Solution {
    private IList<string> res = new List<string>();
    
    public IList<string> LetterCasePermutation(string S) {
        if (S == null || S == string.Empty)
            return res;
        
        Backtrack(S, 0, new StringBuilder());
        
        return res;
    }
    
    private void Backtrack(string S, int i, StringBuilder cur)
    {
        if (i == S.Length)
        {
            res.Add(cur.ToString());
            return;
        }
        
        cur.Append(S[i]);        
        Backtrack(S, i + 1, cur);
        cur.Remove(cur.Length - 1, 1);
        
        if (S[i] >= 'a' && S[i] <= 'z' || S[i] >= 'A' && S[i] <= 'Z')
        {
            cur.Append(S[i] >= 'a' && S[i] <= 'z' ? (char)(S[i] - 32) : (char)(S[i] + 32));        
            Backtrack(S, i + 1, cur);
            cur.Remove(cur.Length - 1, 1);
        }
    }
}