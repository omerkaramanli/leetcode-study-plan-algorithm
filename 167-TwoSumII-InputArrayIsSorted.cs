public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int low = 0, high = numbers.Length-1;
        while(numbers[low]+numbers[high]!=target){
            if(numbers[low]+numbers[high]<target)
                low++;
            else
                high--;
            if(low == high)
                return null;
        }
        int[] tmp = {low+1,high+1};
        return tmp;
    }
}