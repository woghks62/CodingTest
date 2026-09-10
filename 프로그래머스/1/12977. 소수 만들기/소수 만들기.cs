using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int sum = 0;
        int count = 0;
        
        for(int i=0; i<nums.Length-2; i++){
            for(int j=i+1; j<nums.Length-1; j++){
                for(int k=j+1; k<nums.Length; k++){
                    sum = nums[i] + nums[j] + nums[k];
                    
                    for(int n=1; n<=sum; n++){
                        if(sum % n == 0) count++;
                    }
                    if(count == 2) answer++;
                    count = 0;
                }
            }
        }

        return answer;
    }
}