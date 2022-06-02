public class Solution {
    public int Search(int[] nums, int target) {
        int len = nums.Length, left = 0, right = len-1, pivot;
        while(left<=right){
            pivot  = (right + left) / 2;
            if(nums[pivot] == target)
                return pivot;
            else if(nums[pivot]>target)
                right = pivot-1;
            else left = pivot+1;
        }
        return -1;
    }
}