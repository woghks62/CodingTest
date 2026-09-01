using System;

public class Solution {
    public int solution(int[] array) {
        
        int count = 1;
        int max = 0;
        int maxNum = 0;
        bool isSame = false;
        
        if(array.Length == 1){
            return array[0];
        }
        
        for(int i=0; i<array.Length; i++)
        {
            count = 1;
            
            for(int j=i+1; j<array.Length; j++)
            {
                if(array[i] == array[j])
                {
                    count++;
                }
                
            }
            if(count > max){
                max = count;
                maxNum = array[i];
                isSame = false;
            }
            else if(count == max){
                isSame = true;
            }
        }
        
        if(isSame){
            return -1;
        }
        
        return maxNum;
    }
}