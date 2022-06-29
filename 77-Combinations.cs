public class Solution {
    private IList<IList<int>> res = new List<IList<int>>();

    public IList<IList<int>> Combine(int n, int k) {
        //(k!%n)!%2
        if(k==n || k == 0){
            IList<int> tmp = new List<int>();
            for(int i = 1; i<=n; i++){
                tmp.Add(i);
            }
            res.Add(tmp);
            return res;
        }
        else{
            Helper(n, k, 1, new List<int>());            
        }
        return res;
        
        
    }
    
    public void Helper(int n, int k, int i, List<int> l){
         if (l.Count == k)
            res.Add(new List<int>(l));
        else
            for (int j = i; j <= n; j++)
            {
                l.Add(j);
                
                Helper(n, k, j + 1, l);
                
                l.RemoveAt(l.Count - 1);
            }
    }
}