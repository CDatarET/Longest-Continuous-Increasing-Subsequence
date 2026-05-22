class Solution:
    def findLengthOfLCIS(self, nums: List[int]) -> int:
        m = 0
        left = 0
        for i in range(1, len(nums)):
            if nums[i] <= nums[i - 1]:
                left = i
            
            m = max(m, i - left + 1)
        
        return max(m, len(nums) - left)
