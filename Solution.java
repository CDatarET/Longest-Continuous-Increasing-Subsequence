class Solution {
    public int findLengthOfLCIS(int[] nums) {
        int left = 0;
        int max = 0;
        for(int i = 1; i < nums.length; i++){
            if(nums[i] <= nums[i - 1]){
                left = i;
            }

            max = Math.max(max, i - left + 1);
        }

        return(Math.max(max, nums.length - left));
    }
}
