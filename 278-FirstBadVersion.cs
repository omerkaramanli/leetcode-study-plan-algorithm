/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1, right = n, pivot;
        while(left<right){
            pivot = left + (right - left) / 2;
            if(IsBadVersion(pivot)){
                right = pivot;
            }
            else{
                left = pivot+1;
            }
            
        }
        return left;
    }
}