public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left=0, right=nums.Length-1;
        int[] res = new int[nums.Length];
        for(int i = nums.Length-1; i>=0; i--){
            int squareL = nums[left]*nums[left], squareR = nums[right]*nums[right];
            if(squareR>squareL){
                res[i] = squareR;
                right--;
            }
            else{
                res[i] = squareL;
                left++;
            }
        }
        return res;
    }
}