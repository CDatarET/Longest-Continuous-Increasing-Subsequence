public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        int left = 0;
        int max = 0;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] <= nums[i - 1]){
                left = i;
            }

            max = Math.Max(max, i - left + 1);
        }

        return(Math.Max(max, nums.Length - left));
    }
}
