public class Solution {
    private IList<IList<int>> res = new List<IList<int>>();

    public IList<IList<int>> Permute(int[] nums) {
        if (nums == null || nums.Length == 0)
           return new List<IList<int>>();
        
        Helper(nums, new List<int>());            
        
        return res;
        
    }
    
    public void Helper(int[] nums, List<int> l){
        if (l.Count == nums.Length)
            res.Add(new List<int>(l));
        else
            for (int j = 0; j < nums.Length; j++)
            {
                if(l.Contains(nums[j])) continue;
                l.Add(nums[j]);

                Helper(nums, l);

                l.RemoveAt(l.Count - 1);
            }
    }

}

    
