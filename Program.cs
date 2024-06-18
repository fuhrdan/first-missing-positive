//*****************************************************************************
//** 41. First Missing Positive Leetcode                                     **
//** This was a simple search, sort and return first missing number or count **
//** The actual solution to get here was hard, and this is slow code that    **
//** beat 16.94% of other programs, so there are much faster solutions.      **
//** but it works.   --Dan                                                   **
//*****************************************************************************


int firstMissingPositive(int* nums, int numsSize) {
    for (int i = 0; i < numsSize; i++)
    {
        while(nums[i] >= 1 && nums[i] <= numsSize && nums[i] != nums[nums[i] - 1])
        {
            int temp = nums[nums[i] - 1];
            nums[nums[i] - 1] = nums[i];
            nums[i] = temp;
        }
    }

    for( int j = 0; j < numsSize; j++)
    {
        if(nums[j] != j + 1)
        {
            return j+1;
        }
    }
    return numsSize + 1;
}