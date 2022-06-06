public class Solution {
    public void MoveZeroes(int[] nums) {
        int lastNonZero = 0;
        for(int i = 0;i<nums.Length;i++){
            if(nums[i]!=0){    
                nums[lastNonZero] = nums[i];
                lastNonZero++;
            }      
        }
        for(int i = lastNonZero;i<nums.Length;i++){
            nums[i] = 0;
        }
    }
}