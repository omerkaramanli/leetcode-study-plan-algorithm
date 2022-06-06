public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        HashSet<object> chList = new HashSet<object>();
        Queue ansList = new Queue();
        for(int i = 0; i< s.Length;i++){
            if(chList.Contains(s[i])){
                while(ansList.Count>0 && chList.Contains(s[i])){
                    var tmpCh = ansList.Dequeue();
                    chList.Remove(tmpCh);
                }
            }
            chList.Add(s[i]);
            ansList.Enqueue(s[i]);
            if(chList.Count>max) max = chList.Count;
            
        }
        return max;
    }
}