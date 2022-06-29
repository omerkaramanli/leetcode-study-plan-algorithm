public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 0) return 0;
        if(n<=2) return n;
        
        int oneS = 2;
        int twoS = 1;
        int max = 0;
        
        for(int i = 2; i<n; i++){
            max = oneS + twoS;
            twoS = oneS;
            oneS = max;
        }
        
        return max;
    }
}