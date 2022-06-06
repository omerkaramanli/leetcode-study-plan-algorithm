public class Solution {
    public string ReverseWords(string s) {
        string[] sen = s.Split(" ");
        string res = "";
        foreach(var word in sen){
            res += ReverseString(word) + " ";
        }
        return res.Trim();
    }
    
    public string ReverseString(string s) {
        char[] tmpCh = s.ToCharArray();  
        for(int i = 0; i<(tmpCh.Length)/2; i++){
            var tmp = tmpCh[i];
            tmpCh[i] = tmpCh[tmpCh.Length-1-i];
            tmpCh[tmpCh.Length-1-i] = tmp;
        }
        return new string(tmpCh); 
    }
}