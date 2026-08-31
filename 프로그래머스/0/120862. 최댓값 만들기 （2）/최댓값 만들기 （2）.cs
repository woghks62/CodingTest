using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int max = Int32.MinValue;
        
        for(int i=0; i<numbers.Length-1; i++){          //0 1 2 3 
            for(int j=i+1; j<numbers.Length; j++){      // 1 2 3 4
                if(numbers[i] * numbers[j] > max){
                    max = numbers[i] * numbers[j];
                }
            }
        }
        
        answer = max;
        
        return answer;
    }
}