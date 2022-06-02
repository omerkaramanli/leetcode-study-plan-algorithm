public class Solution {
    public void Rotate(int[] nums, int k) {
        int l = nums.Length;
        int[] tmp = new int[l];
        if(l < k){
            k = k%l;
        }
        for(int i = 0; i<k; i++){
            tmp[i] = nums[l-k+i];
        }
        for(int j = 0; j<l-k; j++){
            tmp[k+j] = nums[j];
        }

        for(int m = 0; m<l; m++){
            nums[m] = tmp[m];
        }
        
    }
}